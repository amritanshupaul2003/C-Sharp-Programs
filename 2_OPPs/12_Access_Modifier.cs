using System;

namespace OOPsLearning
{
    class BankAccount
    {
        public string Username;
        private string password;

        public void SetPassword(string pwd)
        {
            password = pwd;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcc = new BankAccount();
            myAcc.Username = "amritanshu paul";
            myAcc.SetPassword("#Amri2024");

            Console.WriteLine("Username: " + myAcc.Username);
        }
    }
}
