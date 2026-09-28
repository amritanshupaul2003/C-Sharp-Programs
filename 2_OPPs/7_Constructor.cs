using System;

namespace OOPsLearning
{
    class Student
    {
        public string Name;
        public int Age;

        // Default constructor
        public Student()
        {
            Name = "Unknown";
            Age = 0;
        }

        // Parameterized constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Alice", 20);

            s1.Display();
            s2.Display();
        }
    }
}
