using System.Net.Sockets;
using AuthCore.Model;
using Core;
using Core.Auth.Dto.Server;

namespace AuthCore.Service
{
    [Handler(0x504)]
    public class ConnectService : ResponseAuthService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet, LoggedUser _loggedUser)
        {
            SendAck(socket, idPacket, new ConnectServerDto());
        }
    }
}
