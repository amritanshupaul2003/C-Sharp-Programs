using System;
using System.Collections.Generic;

namespace RBACLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, List<string>>
            {
                ["admin"] = new List<string> { "Read", "Write", "Delete" },
                ["editor"] = new List<string> { "Read", "Write" },
                ["viewer"] = new List<string> { "Read" }
            };

            string userRole = "editor";
            string action = "Delete";

            if (users.ContainsKey(userRole) && users[userRole].Contains(action))
            {
                Console.WriteLine("Access granted for " + userRole + " to perform: " + action);
            }
            else
            {
                Console.WriteLine("Access denied for " + userRole + " to perform: " + action);
            }
        }
    }
}
