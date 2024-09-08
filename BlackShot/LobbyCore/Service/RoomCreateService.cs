using System.Net.Sockets;
using Core;

namespace LobbyCore.Service
{
    [Handler(0x25)]
    public class RoomCreateService : ResponseLoginService
    {
        public void Execute(Socket socket, ApplicationDbContext _context, ushort idPacket, byte[] packet)
        {
            //SendAck(socket, idPacket, new LoginServerDto(LoginResultEnum.Success));
        }
    }
}