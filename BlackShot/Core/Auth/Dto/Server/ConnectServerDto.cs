using BlubLib.Serialization;
using Core.Auth.Enums;
using Core.Serializer;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class ConnectServerDto : ConnectErrorServerDto
    {
        [BlubMember(1, typeof(BinarySerializer), 125)]
        public byte[] Checksum { get; set; } // This is sent right back from the client on server join (Check Mercenary.Server.Lobby.Messages => LoginReqMessage.Unk1)

        public ConnectServerDto() : base()
        {
            Checksum = Array.Empty<byte>();
        }
    }

    [BlubContract]
    public class ConnectErrorServerDto
    {
        [BlubMember(1)]
        public CharacterScreenResultEnum ScreenResult { get; set; }

        public ConnectErrorServerDto()
        { }
        public ConnectErrorServerDto(CharacterScreenResultEnum result)
        {
            ScreenResult = result;
        }
    }
}
