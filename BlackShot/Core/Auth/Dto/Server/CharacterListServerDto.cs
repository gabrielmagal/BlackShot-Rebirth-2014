using BlubLib.Serialization;
using Core.Auth.Enums;
using Core.Serializer;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class CharacterListServerDto : CharacterListErrorServerDto
    {
        [BlubMember(1)]
        public uint CharacterCount { get; set; }

        [BlubMember(2, typeof(BinarySerializer), 12)]
        public byte[] Padding { get; set; }

        [BlubMember(3, typeof(StringSerializer), 68)]
        public string? Nickname1 { get; set; }

        [BlubMember(4, typeof(StringSerializer), 68)]
        public string? Nickname2 { get; set; }

        [BlubMember(5, typeof(StringSerializer), 68)]
        public string? Nickname3 { get; set; }

        [BlubMember(6, typeof(StringSerializer), 68)]
        public string? Nickname4 { get; set; }

        [BlubMember(7)]
        public byte Flag { get; set; }

        public CharacterListServerDto() : base(0)
        {
            Padding = Array.Empty<byte>();
        }
    }

    [BlubContract]
    public class CharacterListErrorServerDto
    {
        [BlubMember(1)]
        public CharacterInfoError ErrorCode { get; set; }

        public CharacterListErrorServerDto()
        { }
        public CharacterListErrorServerDto(CharacterInfoError error)
        {
            ErrorCode = error;
        }
    }
}
