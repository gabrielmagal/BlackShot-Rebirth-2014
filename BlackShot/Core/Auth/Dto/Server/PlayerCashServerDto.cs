using BlubLib.Serialization;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class PlayerCashServerDto
    {
        [BlubMember(1)]
        public uint Unk1 { get; set; }

        [BlubMember(2)]
        public uint PlayerCash { get; set; }

        public PlayerCashServerDto()
        {

        }

        public PlayerCashServerDto(uint playercash)
        {
            PlayerCash = playercash;
        }
    }
}
