namespace ModelLibrary
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Registration_number { get; set; }

        public Car(string model = "", string color = "", string reg_number = "")
        {
            Model = model;
            Color = color;
            Registration_number = reg_number;
        }
    }
}