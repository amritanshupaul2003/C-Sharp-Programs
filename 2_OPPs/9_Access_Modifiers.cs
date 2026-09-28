using System;

namespace OOPsLearning
{
    class Employee
    {
        public string Name;        // accessible everywhere
        private int salary;        // accessible only within class
        protected int age;         // accessible in derived classes

        public Employee(string name, int salary, int age)
        {
            Name = name;
            this.salary = salary;
            this.age = age;
        }

        public void ShowSalary()
        {
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Manager : Employee
    {
        public Manager(string name, int salary, int age) : base(name, salary, age)
        {
            Console.WriteLine("Manager Name: " + Name);
            Console.WriteLine("Manager Age: " + age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("John", 50000, 30);
            emp.ShowSalary();
            Console.WriteLine("Name: " + emp.Name);

            Manager manager = new Manager("Alice", 70000, 35);
        }
    }
}
