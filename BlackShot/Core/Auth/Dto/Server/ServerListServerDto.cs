using BlubLib.Serialization;
using Core.Auth.Enums;
using Core.Serializer;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class ServerListServerDto
    {
        [BlubMember(1)]
        public ushort Padding { get; set; } // Message starts after 6 bytes of the payload so this is useless

        [BlubMember(2)]
        public byte ServerEntries { get; set; }

        [BlubMember(3, typeof(ArraySerializer))]
        public ServerInfoServerDto[] Servers { get; set; }

        public ServerListServerDto()
        {

        }
    }

    [BlubContract]
    public class ServerInfoServerDto
    {
        [BlubMember(1)]
        public byte Unk1 { get; set; } // Sorting ID?

        [BlubMember(2)]
        public ServerTypeEnum ServerType { get; set; }

        [BlubMember(3)]
        public ushort PlayerLimit { get; set; }

        [BlubMember(4)]
        public ushort PlayerCount { get; set; }

        [BlubMember(5)]
        public ushort ServerPort { get; set; }

        [BlubMember(6)]
        public uint ServerIP { get; set; }

        [BlubMember(7, typeof(BinarySerializer), 241)]
        public byte[] AllowedAreas { get; set; }

        [BlubMember(8, typeof(BinarySerializer), 241)]
        public byte[] BlockedAreas { get; set; }

        [BlubMember(9, typeof(StringSerializer), 33)]
        public string ServerName { get; set; }

        public ServerInfoServerDto()
        {
            AllowedAreas = Array.Empty<byte>();
            BlockedAreas = Array.Empty<byte>();
        }
    }
}
