using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using ModelLibrary;
using Newtonsoft.Json;


namespace PlainServer
{
    public class Server
    {
        private const int Port = 10001;

        public void Start()
        {
            var listener = new TcpListener(IPAddress.Loopback, Port);
            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Run((() => HandleClient(client)));
            }
        }

        private void HandleClient(TcpClient client)
        {
            Console.WriteLine("Start of handling of client");
            while (true)
            {
                var ns = client.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);

                var inc = sr.ReadLine();
                Console.WriteLine($"Received {inc}");

                AutoSale auto = JsonConvert.DeserializeObject<AutoSale>(inc);

                Console.WriteLine($"Received order of {auto.Cars.Count} by {auto.Name}");
                foreach (var car in auto.Cars)
                {
                    Console.WriteLine($"{car.Model} | {car.Color} | {car.Registration_number}");
                }
            }


        }
    }
}