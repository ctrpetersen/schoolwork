using System;

namespace JSONUDPSender
{
    class Program
    {
        private const int PORT = 7;

        static void Main(string[] args)
        {
            Sender sen = new Sender(PORT);
            sen.Start();
            Console.ReadKey();
        }
    }
}
