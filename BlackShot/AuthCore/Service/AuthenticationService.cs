using System.Net.Sockets;
using AuthCore.Model;
using BlubLib.Serialization;
using Core;
using Core.Auth.Dto.Client;
using Core.Auth.Dto.Server;

namespace AuthCore.Service
{
    [Handler(0x4)]
    public class AuthenticationService : ResponseAuthService
    {
        public void ExecuteAuth(Socket socket, ushort idPacket, byte[] packet, ref LoggedUser loggedUser)
        {
            Thread.Sleep(500);

            using var msClient = new MemoryStream(packet);
            var authenticationClientDto = Serializer.Deserialize<AuthenticationClientDto>(msClient);

            var validUser = KeycloakService.ValidateCredentialsAsync(authenticationClientDto.Username.Replace("\0", ""), authenticationClientDto.Auth.Replace("\0", ""));

            if (validUser == false)
            {
                socket.Close();
                return;
            }

            var account = KeycloakService.GetUsersByUsernameAsync(authenticationClientDto.Username.Replace("\0", ""));

            var authenticationServerDto = new AuthenticationServerDto()
            {
                CharacterSlots = 1,
                IsPCRoom = 0,
                AccountNumber = 0,
                Country = "US",
                IsBanned = !account.First().enabled,
                TimeStamp = $"123456789",
            };

            SendAck(socket, idPacket, authenticationServerDto);
            loggedUser.Id = account.First().id;
        }
    }
}
