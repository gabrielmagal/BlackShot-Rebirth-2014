using BlubLib.Serialization;
using System.Net.Sockets;

namespace AuthCore.Service
{
    public class ResponseAuthService
    {
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
                ushort newSize = Convert.ToUInt16(ms.ToArray().Length + 4);
                var packetOrganized = BitConverter.GetBytes(newSize).Concat(BitConverter.GetBytes(idPacket)).Concat(ms.ToArray()).ToArray();
                socket.Send(packetOrganized);
            }
        }
    }
}
