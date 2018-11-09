using System;

namespace JSONUDPReceiver
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
