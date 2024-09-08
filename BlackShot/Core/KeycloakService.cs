using System.Text;
using System.Text.Json;
using Core.Auth.Model;

namespace Core
{
    public static class KeycloakService
    {
        private static readonly HttpClient _httpClient = new ();
        private static readonly string _authority = "http://host.docker.internal:8083";
        private static readonly string _clientId = "blackshot-api";
        private static readonly string _clientSecret = "QJOOICA08nW8W9yaWMaqXGdV9nKpOIDu";
        private static readonly string _realm = "blackshot";

        public static string GetTokenAsync()
        {
            var tokenEndpoint = $"{_authority}/realms/{_realm}/protocol/openid-connect/token";
            var requestBody = new StringContent(
                $"client_id={_clientId}&client_secret={_clientSecret}&grant_type=client_credentials",
                Encoding.UTF8,
                "application/x-www-form-urlencoded"
            );

            var response = _httpClient.PostAsync(tokenEndpoint, requestBody);
            if (response.Result.IsSuccessStatusCode)
            {
                var responseContent = response.Result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TokenResponse>(responseContent.Result)?.access_token ?? "";
            }
            throw new Exception($"[{response.Result.StatusCode}] Erro ao obter token de acesso. - {response.Result.Content}");
        }

        public static void CreateUserAsync(string username, string password, string email, string firstName = "", string lastName = "")
        {
            var byUsername = GetUsersByUsernameAsync(username);
            var byEmail = GetUsersByEmailAsync(email);

            if (byUsername.Count() > 0 || byEmail.Count() > 0)
            {
                throw new Exception("Usuário ou e-mail já estão em uso.");
            }

            var token = GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var user = new
            {
                username,
                email,
                firstName,
                lastName,
                enabled = true,
                credentials = new[]
                {
                    new
                    {
                        type = "password",
                        value = password,
                        temporary = false
                    }
                }
            };

            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            var response = _httpClient.PostAsync($"{_authority}/admin/realms/{_realm}/users", content);

            if (!response.Result.IsSuccessStatusCode)
            {
                throw new Exception($"Erro ao criar usuário: {response.Result.ReasonPhrase}");
            }
        }

        public static IEnumerable<User> GetUsersAsync()
        {
            var token = GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = _httpClient.GetAsync($"{_authority}/admin/realms/{_realm}/users");

            if (!response.Result.IsSuccessStatusCode)
            {
                throw new Exception($"Erro ao obter usuários: {response.Result.ReasonPhrase}");
            }

            var usersJson = response.Result.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<User>>(usersJson.Result);
        }

        public static string GetUserAsync(string userId)
        {
            var token = GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = _httpClient.GetAsync($"{_authority}/admin/realms/{_realm}/users/{userId}");

            if (!response.Result.IsSuccessStatusCode)
            {
                throw new Exception($"Erro ao obter usuário: {response.Result.ReasonPhrase}");
            }

            var userJson = response.Result.Content.ReadAsStringAsync();
            return userJson.Result;
        }

        public static IEnumerable<User> GetUsersByUsernameAsync(string username)
        {
            var token = GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = _httpClient.GetAsync($"{_authority}/admin/realms/{_realm}/users?username={username}");

            if (!response.Result.IsSuccessStatusCode)
            {
                throw new Exception($"Erro ao obter usuários: {response.Result.ReasonPhrase}");
            }

            var usersJson = response.Result.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(usersJson.Result);

            return users.Where(u => u.username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<User> GetUsersByEmailAsync(string email)
        {
            var token = GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = _httpClient.GetAsync($"{_authority}/admin/realms/{_realm}/users?email={email}");

            if (!response.Result.IsSuccessStatusCode)
            {
                throw new Exception($"Erro ao obter usuários: {response.Result.ReasonPhrase}");
            }

            var usersJson = response.Result.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(usersJson.Result);

            return users.Where(u => u.email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public static bool SendPasswordResetEmailAsync(string email)
        {
            var users = GetUsersByEmailAsync(email);
            var user = users.FirstOrDefault();

            if (user == null)
            {
                throw new Exception("Usuário não encontrado com o e-mail informado.");
            }

            var token = GetTokenAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var resetPasswordResponse = _httpClient.PutAsync(
                $"{_authority}/admin/realms/{_realm}/users/{user.id}/execute-actions-email?client_id={_clientId}",
                new StringContent(JsonSerializer.Serialize(new[] { "UPDATE_PASSWORD" }), Encoding.UTF8, "application/json")
            );

            if (!resetPasswordResponse.Result.IsSuccessStatusCode)
            {
                throw new Exception($"Erro ao enviar solicitação de recuperação de senha: {resetPasswordResponse.Result.ReasonPhrase}");
            }

            return true;
        }

        public static bool ValidateCredentialsAsync(string username, string password)
        {
            var tokenEndpoint = $"{_authority}/realms/{_realm}/protocol/openid-connect/token";
            var requestBody = new StringContent(
                $"client_id={_clientId}&client_secret={_clientSecret}&grant_type=password&username={username}&password={password}",
                Encoding.UTF8,
                "application/x-www-form-urlencoded"
            );

            var response = _httpClient.PostAsync(tokenEndpoint, requestBody);

            return response.Result.IsSuccessStatusCode;
        }

        private class TokenResponse
        {
            public string? access_token { get; set; }
        }

        public class User
        {
            public string id { get; set; }
            public long createdTimestamp { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public bool enabled { get; set; }
            public bool totp { get; set; }
            public bool emailVerified { get; set; }
            public IEnumerable<string> disableableCredentialTypes { get; set; }
            public IEnumerable<string> requiredActions { get; set; }
            public int notBefore { get; set; }
            public Access access { get; set; }
        }

        public class UserCharacterInfoModel
        {
            public User? user { get; set; }
            public CharacterInfoModel? characterInfoModel { get; set; }
        }

        public class Access
        {
            public bool ManageGroupMembership { get; set; }
            public bool View { get; set; }
            public bool MapRoles { get; set; }
            public bool Impersonate { get; set; }
            public bool Manage { get; set; }
        }
    }
}
