using System;

namespace OOPsLearning
{
    class Table
    {
        public int Capacity;
        public string Colour;
        public int Height;
        public string Material;

        public void ChangeCapacity(int cap)
        {
            this.Capacity = cap;
            Console.WriteLine(this.Capacity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Table obj1 = new Table();
            obj1.ChangeCapacity(100);
        }
    }
}
