using System.Net.Sockets;
using BlubLib.Serialization;

namespace LobbyCore.Service
{
    public class ResponseLoginService
    {
        public short Lobbyheader = 255;
        public int MagicHeader = 0x40302010;

        public void SendAck(Socket socket, ushort idPacket, object objAck)
        {
            if (objAck is byte[] byteArray) // Pacotes mocados.
            {
                socket.Send(byteArray);
            }
            else
            {
                using var ms = new MemoryStream();
                Serializer.Serialize(ms, objAck);
                ushort newSize = Convert.ToUInt16(ms.ToArray().Length + 10);

                var packetOrganized = BitConverter.GetBytes(newSize)
                        .Concat(BitConverter.GetBytes(Lobbyheader))
                        .Concat(BitConverter.GetBytes(MagicHeader))
                        .Concat(BitConverter.GetBytes(idPacket))
                        .Concat(ms.ToArray()).ToArray();

                socket.Send(packetOrganized);
            }
        }
    }
}
