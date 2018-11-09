using System;

namespace ModelLib
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegNumber { get; set; }

        public Car(string model, string color, string regNumber)
        {
            Model = model;
            Color = color;
            RegNumber = regNumber;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Color)}: {Color}, {nameof(RegNumber)}: {RegNumber}";
        }


    }
}
