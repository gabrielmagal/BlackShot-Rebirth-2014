using System.Net.Sockets;
using AuthCore.Model;
using BlubLib.Serialization;
using Core;
using Core.Auth.Dto.Client;
using Core.Auth.Dto.Server;
using Core.Auth.Model;

namespace AuthCore.Service
{
    [Handler(0x304)]
    public class CharacterCreateService : ResponseAuthService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet, LoggedUser _loggedUser)
        {
            using var msClient = new MemoryStream(packet);
            var characterCreateClientDto = Serializer.Deserialize<CharacterCreateClientDto>(msClient);

            string hexString = BitConverter.ToString(packet).Replace("-", " ");

            var characterInfoModel = new CharacterInfoModel
            {
                Nickname = characterCreateClientDto.Nickname.Replace("\0", ""),
                AccountNumber = Guid.Parse(_loggedUser.Id),
                SkinColor = characterCreateClientDto.SkinColor,
                Hero = characterCreateClientDto.Hero,
            };

            _context.CharacterInfoModel.Add(characterInfoModel);
            _context.SaveChanges();

            SendAck(socket, idPacket, new CharacterCreateServerDto());
        }
    }
}
