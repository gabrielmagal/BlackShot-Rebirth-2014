using Core.Serializer;
using BlubLib.Serialization;

namespace Core.Auth.Dto.Server
{
    [BlubContract]
    public class ChannelListServerDto
    {
        [BlubMember(1, typeof(ArraySerializer))]
        public ChannelDto[] Channels { get; set; }
    }

    [BlubContract]
    public class ChannelDto
    {
        [BlubMember(1)]
        public ushort PlayerCount { get; set; }

        [BlubMember(2)]
        public uint PlayerLimit { get; set; }

        [BlubMember(3)]
        public ushort Pad { get; set; }

        [BlubMember(4)]
        public byte Unk1 { get; set; }

        [BlubMember(5)]
        public byte Unk2 { get; set; }
    }
}
