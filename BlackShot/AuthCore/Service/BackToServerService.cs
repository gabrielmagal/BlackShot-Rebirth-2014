using AuthCore.Model;
using Core;
using System.Net.Sockets;

namespace AuthCore.Service
{
    [Handler(0xA04)]
    public class BackToServerService : ResponseAuthService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet, LoggedUser _loggedUser)
        {
            SendAck(socket, idPacket, new byte[] { 0x0f, 0x00, 0x04, 0x0a, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
        }
    }
}
