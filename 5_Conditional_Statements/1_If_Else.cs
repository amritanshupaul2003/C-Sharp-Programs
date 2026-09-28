using System;

namespace ConditionalLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks = 78;

            if (marks >= 80)
            {
                Console.WriteLine("Excellent");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Need improvement");
            }
        }
    }
}
