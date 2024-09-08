﻿using System.Net;
using System.Net.Sockets;
using System.Reflection;
using Core;
using LobbyCore.Service;

namespace LobbyCore.View
{
    public class MainServerLobbyCore
    {
        private static readonly Dictionary<int, dynamic> _handlerMap = [];
        private static readonly ApplicationDbContext _context = new();

        static void Main(string[] args)
        {
            Console.WriteLine($"[-] Starting Server {DateTime.Now}");

            int porta = 30003;
            var enderecoIP = IPAddress.Any;
            var endPoint = new IPEndPoint(enderecoIP, porta);
            InitializeHandlers();

            var socket = new Socket(enderecoIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Bind(endPoint);
                socket.Listen(50);
                Console.WriteLine($"[-] Lobby Server Started Successfully {DateTime.Now}");
                while (true)
                {
                    var clientSocket = socket.Accept();
                    Console.WriteLine("Conexão feita!");
                    var connection = new ConnectionPoolService(clientSocket, _handlerMap, _context);
                    Task.Run(() => {
                        connection.HandleConnectionAsync();
                    });
                }
            }
            finally
            {
                socket.Close();
            }
        }

        private static void InitializeHandlers()
        {
            var handlerTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetCustomAttribute<HandlerAttribute>() != null);

            foreach (var handlerType in handlerTypes)
            {
                HandlerAttribute? handlerAttribute = handlerType.GetCustomAttribute<HandlerAttribute>();
                if (handlerAttribute != null && !_handlerMap.ContainsKey(handlerAttribute.Id))
                {
                    var instance = Activator.CreateInstance(handlerType);
                    _handlerMap.Add(handlerAttribute.Id, instance);
                }
            }
        }
    }
}
