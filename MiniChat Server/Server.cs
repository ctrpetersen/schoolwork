using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Minichat_Server
{
    public class Server
    {
        public int Port;

        public Server(int port)
        {
            Port = port;
        }

        public void Start()
        {
            Console.WriteLine($"Server started at port {Port}. Listening for clients.");
            var listener = new TcpListener(IPAddress.Loopback, Port);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Run(() => HandleClient(client));
                Console.WriteLine($"New client | {client.Client.RemoteEndPoint}");
            }
        }

        private void HandleClient(TcpClient client)
        {
            var ns = client.GetStream();
            var sr = new StreamReader(ns);
            var sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            Task.Run(() =>
            {
                while (true)
                {
                    var iString = sr.ReadLine();

                    if (iString == "STOP")
                    {
                        Console.WriteLine($"Terminating connection at {client.Client.RemoteEndPoint}");
                        client.Close();
                        return;
                    }

                    Console.WriteLine("Client :: " + iString);
                }
            });

            while (true)
            {
                var rl = Console.ReadLine();
                if (rl == "STOP")
                {
                    Console.WriteLine($"Terminating connection at {client.Client.RemoteEndPoint}");
                    client.Close();
                    return;
                }
                sw.Write("Server :: " + rl + "\n");
            }
        }
    }
}