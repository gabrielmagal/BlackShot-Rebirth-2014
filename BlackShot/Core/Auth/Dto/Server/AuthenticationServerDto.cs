using Core.Serializer;
using BlubLib.Serialization;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class AuthenticationServerDto : AuthenticationServerErrorDto
    {
        [BlubMember(1, typeof(BinarySerializer), 10)]
        public byte[] Padding { get; set; }

        [BlubMember(2)]
        public uint CharacterSlots { get; set; }

        [BlubMember(3)]                      // Was used back in the day when garena was organizing LAN tournaments in internet coffee shops 
        public uint IsPCRoom { get; set; } = 0;    // Client actually expects 1 byte only since it's a boolean but them ape devs forgot to correctly cast it on their end *sigh*

        [BlubMember(4)]
        public byte Padding2 { get; set; }

        [BlubMember(5)]
        public uint AccountNumber { get; set; }

        [BlubMember(6, typeof(StringSerializer), 4)]
        public string Country { get; set; }

        [BlubMember(7)]
        public bool IsBanned { get; set; }

        [BlubMember(8)]
        public byte Unk1 { get; set; }

        [BlubMember(9, typeof(StringSerializer), 16)]
        public string TimeStamp { get; set; }

        public AuthenticationServerDto() : base(0, 0)
        {
            Padding = Array.Empty<byte>();
            Unk1 = 0;
        }

    }

    [BlubContract]
    public class AuthenticationServerErrorDto
    {
        [BlubMember(1)]
        public ushort ErrorCode { get; set; }

        [BlubMember(2)]
        public uint AuthErrorCode { get; set; }

        public AuthenticationServerErrorDto()
        { }
        public AuthenticationServerErrorDto(int errorCode, int authErrorCode)
        {
            ErrorCode = (ushort)errorCode;
            AuthErrorCode = (uint)authErrorCode;
        }
    }
}
