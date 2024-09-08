using System.Net.Sockets;
using AuthCore.Model;
using Core;
using Core.Auth.Dto.Server;
using Microsoft.EntityFrameworkCore;

namespace AuthCore.Service
{
    [Handler(0x104)]
    public class CharacterListService : ResponseAuthService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet, LoggedUser _loggedUser)
        {
            Thread.Sleep(500);

            var dbCharacterInfo = _context.CharacterInfoModel.AsNoTracking().FirstOrDefault(c => c.AccountNumber == Guid.Parse(_loggedUser.Id));

            if (dbCharacterInfo == null)
            {
                SendAck(socket, idPacket, new CharacterListServerDto()
                {
                    CharacterCount = 0
                });
            }
            else
            {
                var characterListServerDto = new CharacterListServerDto()
                {
                    CharacterCount = 1,
                    Nickname1 = dbCharacterInfo.Nickname.Replace("\0", "")
                };
                SendAck(socket, idPacket, characterListServerDto);
            }
        }
    }
}
