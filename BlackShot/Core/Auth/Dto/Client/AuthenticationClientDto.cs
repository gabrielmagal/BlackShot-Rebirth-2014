using Core.Serializer;
using BlubLib.Serialization;

namespace Core.Auth.Dto.Client
{
    [BlubContract]
    public class AuthenticationClientDto
    {
        [BlubMember(1)]
        public uint AccountNumber { get; set; }

        [BlubMember(2, typeof(StringSerializer), 17)]
        public string Username { get; set; }

        [BlubMember(3, typeof(BinarySerializer), 60)]
        public byte[] Padding { get; set; }

        [BlubMember(4, typeof(StringSerializer), 10)]
        public string Auth { get; set; }
    }
}
