using System;
using System.Collections.Generic;
using ModelLibrary;
using Newtonsoft.Json;

namespace PlainServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //            List<Car> cars = new List<Car>();
            //            Car c1 = new Car("Dodge Ram", "Orange", "120FL31");
            //            Car c2 = new Car("Tesla Model S", "Blue", "ELON2211");
            //            Car c3 = new Car("Opel Kadet", "Black", "OPEL10001");
            //            cars.Add(c1);
            //            cars.Add(c2);
            //            cars.Add(c3);
            //            AutoSale Auto = new AutoSale(cars, "3 very expensive cars", "Ravnsholt 205 1.TV");
            //
            //            string json = JsonConvert.SerializeObject(Auto);
            //            Console.WriteLine(json);

            var s = new Server();
            s.Start();

            Console.ReadKey();
        }
    }
}
