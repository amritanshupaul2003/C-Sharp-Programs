using System;

namespace OOPsLearning
{
    // Abstract class cannot be instantiated directly
    abstract class Shape
    {
        public abstract double Area();

        public void DisplayName()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(5);
            shape.DisplayName();
            Console.WriteLine("Area of circle: " + shape.Area());
        }
    }
}
