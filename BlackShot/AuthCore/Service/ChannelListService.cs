using System.Net.Sockets;
using AuthCore.Model;
using Core;
using Core.Auth.Dto.Server;

namespace AuthCore.Service
{
    [Handler(0x704)]
    public class ChannelListService : ResponseAuthService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet, LoggedUser _loggedUser)
        {
            SendAck(socket, idPacket, new ChannelListServerDto()
            {
                Channels =
                    [
                        new() {
                            Unk1 = 0,
                            Unk2 = 0,
                            PlayerCount = 0,
                            PlayerLimit = 450
                        }
                    ]
            });
        }
    }
}
