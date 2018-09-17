using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TCPServer
{
    internal class TCPServer
    {
        private int _port;

        public TCPServer(int port)
        {
            _port = port;
        }

        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, _port);
            listener.Start();

            using (TcpClient socket = listener.AcceptTcpClient())
            {
                DoClient(socket);
            }
        }

        public void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string incString = sr.ReadLine();
                Console.WriteLine($"Received message - {incString}");

                int wordCount = incString.Split(' ').Length;

                sw.WriteLine($"You sent me {wordCount} words.");
                sw.Flush();
            }
        }
    }
}