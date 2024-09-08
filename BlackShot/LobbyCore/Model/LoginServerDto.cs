using BlubLib.Serialization;
using LobbyCore.Enums;

namespace LobbyCore.Model
{
    [BlubContract]
    public class LoginServerDto
    {
        [BlubMember(1)]
        public LoginResultEnum LoginResult { get; set; }

        public LoginServerDto()
        {

        }
        public LoginServerDto(LoginResultEnum loginResult)
        {
            LoginResult = loginResult;
        }
    }
}
