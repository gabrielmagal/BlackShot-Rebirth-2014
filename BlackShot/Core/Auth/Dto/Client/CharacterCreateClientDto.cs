using Core.Serializer;
using BlubLib.Serialization;

namespace Core.Auth.Dto.Client
{
    [BlubContract]
    public class CharacterCreateClientDto
    {

        [BlubMember(1, typeof(StringSerializer), 17)]
        public string Nickname { get; set; }

        [BlubMember(2)]
        public byte Hero { get; set; }

        [BlubMember(3)]
        public byte SkinColor { get; set; }
    }
}
