using System;

namespace ExceptionLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = 10;
                int zero = 0;
                int result = value / zero;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This always runs.");
            }
        }
    }
}
