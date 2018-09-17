using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    class Client
    {
        public void Start()
        {
            using (TcpClient socket = new TcpClient("localhost", 7777))
            {
                var ns = socket.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);

                sw.WriteLine(ns);
                sw.Flush();

                string incString = sr.ReadLine();
                Console.WriteLine(incString);
            }
        }
    }
}
