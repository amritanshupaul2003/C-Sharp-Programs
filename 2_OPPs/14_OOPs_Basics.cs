using System;

namespace OOPsLearning
{
    class Pen
    {
        public string Color;
        public int Tip;

        public void SetColor(string newColor)
        {
            Color = newColor;
        }

        public void SetTip(int newTip)
        {
            Tip = newTip;
        }
    }

    class Student
    {
        public string Name;
        public int Age;
        public float Percentage;

        public void CalcPercentage(int phy, int chem, int math)
        {
            Percentage = (phy + chem + math) / 3f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.SetColor("Blue");
            Console.WriteLine(p1.Color);

            p1.SetTip(5);
            Console.WriteLine(p1.Tip);

            p1.Color = "Yellow";
            Console.WriteLine(p1.Color);
        }
    }
}
