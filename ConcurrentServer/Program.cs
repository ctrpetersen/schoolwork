using System;

namespace ConcurrentServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new ConcurrentServer(7777);

            server.Start();
            Console.ReadKey();
        }
    }
}
