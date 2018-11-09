using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace JSONUDPReceiver
{
    internal class Receiver
    {
        private int _port;


        public Receiver(int port)
        {
            _port = port;
        }

        public void Start()
        {
            IPEndPoint endP = new IPEndPoint(IPAddress.Any, 0);

            using (UdpClient client = new UdpClient(_port))
            {
                while (true)
                {
                    HandleOneRequest(client, endP);
                }
            }
        }

        private void HandleOneRequest(UdpClient client, IPEndPoint endP)
        {
            byte[] data = client.Receive(ref endP);
            var instr = Encoding.ASCII.GetString(data);
            Console.WriteLine($"Received {instr} from {endP.Address}:{endP.Port}");
        }
    }
}