using System.Net.Sockets;
using AuthCore.Model;
using Core;
using Core.Auth.Dto.Server;
using Core.Auth.Enums;
using Microsoft.EntityFrameworkCore;

namespace AuthCore.Service
{
    [Handler(0x204)]
    public class CharacterInfoService : ResponseAuthService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet, LoggedUser _loggedUser)
        {
            Thread.Sleep(500);

            var dbCharacterInfo = _context.CharacterInfoModel.AsNoTracking().FirstOrDefault(c => c.AccountNumber == Guid.Parse(_loggedUser.Id));

            if (dbCharacterInfo == null)
            {
                socket.Close();
                return;
            }

            var characterInfoServerDto = new CharacterInfoServerDto()
            {
                CharacterID = dbCharacterInfo.CharacterID,
                Nickname = dbCharacterInfo.Nickname.Replace("\0", ""),
                Level = dbCharacterInfo.Level,
                Hero = (CharacterHeroEnum)dbCharacterInfo.Hero,
                Experience = dbCharacterInfo.Experience,
                BountyPoints = dbCharacterInfo.BountyPoints,
                Kills = dbCharacterInfo.Kills,
                Deaths = dbCharacterInfo.Deaths,
                Wins = dbCharacterInfo.Wins,
                Losses = dbCharacterInfo.Losses,
                ClanName = dbCharacterInfo.ClanName,
                ClanMark = dbCharacterInfo.ClanMark,
                SkinColor = dbCharacterInfo.SkinColor,
                ItemCount = 0,
            };

            SendAck(socket, idPacket, characterInfoServerDto);

            SendAck(socket, 0xb0d, new PlayerCashServerDto(dbCharacterInfo.PlayerCash)); // GS
        }
    }
}
