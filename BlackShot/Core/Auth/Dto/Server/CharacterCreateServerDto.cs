using BlubLib.Serialization;
using Core.Auth.Enums;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class CharacterCreateServerDto : CharacterCreationErrorServerDto
    {
        [BlubMember(1)]
        public uint Unk1 { get; set; } // Slot?

        public CharacterCreateServerDto() : base()
        {

        }
    }

    [BlubContract]
    public class CharacterCreationErrorServerDto
    {
        [BlubMember(1)]
        public CharacterCreationErrorEnum ErrorCode { get; set; }

        public CharacterCreationErrorServerDto()
        { }
        public CharacterCreationErrorServerDto(CharacterCreationErrorEnum error)
        {
            ErrorCode = error;
        }
    }
}
