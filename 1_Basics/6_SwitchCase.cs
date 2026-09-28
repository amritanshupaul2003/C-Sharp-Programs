using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Case Example");

            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend or Invalid Day");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Break and Continue Example");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Skipping 5 using continue");
                    continue; // jumps to next iteration
                }

                if (i == 8)
                {
                    Console.WriteLine("Stopping loop at 8 using break");
                    break; // exits the loop completely
                }

                Console.WriteLine("Number: " + i);
            }
        }
    }
}
