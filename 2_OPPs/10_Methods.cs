using System;

namespace OOPsLearning
{
    class Computer
    {
        public void PlayMusic()
        {
            Console.WriteLine("Music playing...");
        }

        public string GetMeAPen(int cost)
        {
            if (cost >= 10)
                return "Pen";

            return "Nothing";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer obj = new Computer();
            obj.PlayMusic();

            string result = obj.GetMeAPen(10);
            Console.WriteLine(result);
        }
    }
}
