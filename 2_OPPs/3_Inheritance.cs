using System;

namespace OOPsLearning
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Eat();      // inherited from Animal
            dog.Bark();     // own method
        }
    }
}
