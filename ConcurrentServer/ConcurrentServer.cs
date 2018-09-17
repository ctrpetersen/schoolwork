using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ConcurrentServer
{
    public class ConcurrentServer
    {
        private int _port;

        public ConcurrentServer(int port)
        {
            _port = port;
        }

        public void Start()
        {
            var listener = new TcpListener(IPAddress.Loopback, _port);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Run((() => HandleClient(client)));
            }
        }

        private void HandleClient(TcpClient client)
        {
            Console.WriteLine("Start of handling of client");
            while (true)
            {
                var sr = new StreamReader(client.GetStream());
                var sw = new StreamWriter(client.GetStream());
                var inc = sr.ReadLine();

                Console.WriteLine($"Received :: {inc}");
                sw.Write($"Echoing your message :: {inc}");
                sw.Flush();
            }
        }

    }
}