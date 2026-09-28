using System;

namespace OOPsLearning
{
    class Human
    {
        private int age;
        private string name;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human obj = new Human();
            obj.SetAge(30);
            obj.SetName("Andy");

            Console.WriteLine(obj.GetName() + ": " + obj.GetAge());
        }
    }
}
