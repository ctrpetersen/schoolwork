using System;

namespace TCPServer
{
    class Program
    {
        private const int Port = 7777;

        static void Main(string[] args)
        {
            TCPServer server = new TCPServer(Port);
            server.Start();

            Console.ReadKey();

        }
    }
}
