using BlubLib.Serialization;
using Core.Auth.Enums;
using Core.Serializer;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class CharacterInfoServerDto : CharacterInfoErrorServerDto
    {
        [BlubMember(1)]
        public uint CharacterID { get; set; }

        [BlubMember(2, typeof(StringSerializer), 17)]
        public string Nickname { get; set; }

        [BlubMember(3)]
        public ushort Level { get; set; }

        [BlubMember(4)]
        public CharacterHeroEnum Hero { get; set; }

        [BlubMember(5)]
        public uint Experience { get; set; }

        [BlubMember(6)]
        public uint BountyPoints { get; set; }

        [BlubMember(7)]
        public uint Unk1 { get; set; }

        [BlubMember(8)]
        public uint Kills { get; set; }

        [BlubMember(9)]
        public uint Deaths { get; set; }

        [BlubMember(10)]
        public uint Wins { get; set; }

        [BlubMember(11)]
        public int Losses { get; set; }

        [BlubMember(12, typeof(BinarySerializer), 16)]
        public byte[] Padding { get; set; } // either a string or ape devs

        [BlubMember(13)]
        public uint Unk2 { get; set; }

        [BlubMember(14)]
        public uint Unk3 { get; set; }

        [BlubMember(15, typeof(StringSerializer), 17)]
        public string? ClanName { get; set; }

        [BlubMember(16)]
        public uint ClanMark { get; set; }

        [BlubMember(17)]
        public short SkinColor { get; set; }

        [BlubMember(18)]
        public byte ItemCount { get; set; }

        // [BlubMember(19, typeof(ArraySerializer))]
        //public CharacterItemDto[] Items { get; set; }

        public CharacterInfoServerDto() : base()
        {
            Padding = Array.Empty<byte>();
            Unk1 = 0;
            Unk2 = 0;
            Unk3 = 0;
            //Items = Array.Empty<CharacterItemDto>();
        }
    }

    [BlubContract]
    public class CharacterInfoErrorServerDto
    {
        [BlubMember(1)]
        public CharacterInfoError ErrorCode { get; set; }

        public CharacterInfoErrorServerDto()
        { }
        public CharacterInfoErrorServerDto(CharacterInfoError error)
        {
            ErrorCode = error;
        }
    }
}
