using System;
using System.Runtime.InteropServices;

namespace PlainUDPSender
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
