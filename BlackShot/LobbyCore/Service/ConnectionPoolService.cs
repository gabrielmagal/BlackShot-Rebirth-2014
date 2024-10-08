﻿using System.Net.Sockets;
using System.Text;
using Core;

namespace LobbyCore.Service
{
    public class ConnectionPoolService
    {
        private readonly Socket _socket;
        private readonly Dictionary<int, dynamic> _handlerMap;
        private readonly ApplicationDbContext _context;

        public ConnectionPoolService(Socket socket, Dictionary<int, dynamic> handlerMap, ApplicationDbContext context)
        {
            _socket = socket;
            _handlerMap = handlerMap;
            _context = context;
        }

        public void HandleConnectionAsync()
        {
            byte[] buffer = new byte[4096];
            try
            {
                while (true)
                {
                    int lenghtReceived = _socket.Receive(buffer);
                    if (lenghtReceived > 0)
                    {
                        byte[] bufferReceived = new byte[lenghtReceived];
                        Array.Copy(buffer, bufferReceived, lenghtReceived);
                        ushort idPacket = BitConverter.ToUInt16(bufferReceived, 8);

                        Console.WriteLine($"Handle: {_socket.Handle} , Pacote: 0x{idPacket:X}");

                        if (_handlerMap.TryGetValue(idPacket, out var handler))
                        {
                            handler.Execute(_socket, _context, idPacket, bufferReceived.Skip(10).ToArray());
                        }
                        else
                        {
                            Console.WriteLine($"Handler não encontrado para ID: 0x{idPacket:X} - {PrintByteArray(bufferReceived)}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao lidar com a requisição do cliente - {_socket.Handle} : {ex.Message}");
            }
            finally
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
            }
        }

        public static string PrintByteArray(byte[] bufferReceived)
        {
            var hex = new StringBuilder(bufferReceived.Length * 5);

            for (int i = 0; i < bufferReceived.Length; i++)
            {
                hex.AppendFormat("0x{0:X2}", bufferReceived[i]);
                if (i < bufferReceived.Length - 1)
                    hex.Append(", ");
            }
            return hex.ToString();
        }
    }
}
