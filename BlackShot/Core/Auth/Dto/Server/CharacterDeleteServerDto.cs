using BlubLib.Serialization;
using Core.Auth.Enums;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class CharacterDeleteServerDto : CharacterDeleteErrorServerDto
    {
        [BlubMember(1)]
        public uint Unk1 { get; set; }

        public CharacterDeleteServerDto() : base()
        {

        }
    }

    [BlubContract]
    public class CharacterDeleteErrorServerDto
    {
        [BlubMember(1)]
        public CharacterScreenResultEnum ScreenResult { get; set; }

        public CharacterDeleteErrorServerDto()
        { }
        public CharacterDeleteErrorServerDto(CharacterScreenResultEnum result)
        {
            ScreenResult = result;
        }
    }
}
