using System;
using System.IO;

namespace FileIOLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "notes.txt";
            File.WriteAllText(path, "Hello from C# file I/O");

            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
    }
}
