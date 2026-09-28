using System;

namespace OOPsLearning
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { new Dog(), new Cat() };

            foreach (Animal animal in animals)
            {
                animal.Sound();
            }
        }
    }
}
