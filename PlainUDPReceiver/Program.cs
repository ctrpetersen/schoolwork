using System;
using System.Runtime.InteropServices;

namespace PlainUDPReceiver
{
    class Program
    {
        private const int PORT = 7;

        static void Main(string[] args)
        {
            Receiver rec = new Receiver(PORT);
            rec.Start();
            Console.ReadKey();
        }
    }
}
