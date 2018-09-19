using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new RESTConsumer();
            r.Start();
            Console.ReadKey();
        }
    }
}
