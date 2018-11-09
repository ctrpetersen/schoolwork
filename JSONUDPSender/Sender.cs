using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace JSONUDPSender
{
    internal class Sender
    {
        private int _port;

        public Sender(int port)
        {
            _port = port;
        }

        public void Start()
        {
            var c = new Car("Tesla Model S", "Red", "0022004134");
            var endP = new IPEndPoint(IPAddress.Broadcast, _port);

            using (UdpClient client = new UdpClient())
            {
                client.EnableBroadcast = true;
                var cByte = Encoding.ASCII.GetBytes(c.ToString());

                client.Send(cByte, cByte.Length, endP);

                Console.WriteLine($"Sent {c} to {endP.Address}:{endP.Port}");
            }
        }
    }
}