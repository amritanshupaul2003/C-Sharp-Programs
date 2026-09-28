using System;

namespace OOPsLearning
{
    class Animal
    {
        // Base class method
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        // Derived class overrides the base method
        public override void Sound()
        {
            Console.WriteLine("Dog barks: Woof! Woof!");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows: Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Dog();
            Animal a3 = new Cat();

            a1.Sound();
            a2.Sound();
            a3.Sound();
        }
    }
}
