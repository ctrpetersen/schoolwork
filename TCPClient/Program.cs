﻿using System;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Start();

            Console.ReadKey();

        }
    }
}
