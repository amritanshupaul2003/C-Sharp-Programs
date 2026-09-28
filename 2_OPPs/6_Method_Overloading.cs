using System;

namespace OOPsLearning
{
    class MathHelper
    {
        // Method overloading = same method name, different parameters
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathHelper helper = new MathHelper();

            Console.WriteLine(helper.Add(2, 3));
            Console.WriteLine(helper.Add(2.5, 3.5));
            Console.WriteLine(helper.Add(1, 2, 3));
        }
    }
}
