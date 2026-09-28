using System;

namespace OOPsLearning
{
    // Class = blueprint
    class Car
    {
        public string Model;
        public int Speed;

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Car Model: " + Model);
            Console.WriteLine("Car Speed: " + Speed + " km/h");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object = real instance of class
            Car myCar = new Car("Toyota", 120);
            myCar.DisplayInfo();
        }
    }
}
