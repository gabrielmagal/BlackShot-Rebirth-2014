using System.Net;
using System.Net.Sockets;
using AuthCore.Model;
using Core;
using Core.Auth.Dto.Server;
using Core.Auth.Enums;

namespace AuthCore.Service
{
    [Handler(0x604)]
    public class ServerListService : ResponseAuthService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet, LoggedUser _loggedUser)
        {
            SendAck(socket, idPacket, new ServerListServerDto()
            {
                ServerEntries = 1,
                Servers =
                    [
                        new ServerInfoServerDto
                        {
                            ServerType = ServerTypeEnum.OpenServer,
                            ServerPort = 30003,
                            ServerIP = (uint)IPAddress.Parse("127.0.0.1").Address,
                            PlayerLimit = 10,
                            PlayerCount = 9,
                            ServerName = "Warfare Server"
                        }
                    ]
            });
        }
    }
}
