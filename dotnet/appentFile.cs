using System;

//We need to include this namespace for file handling.
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string s;

            Console.WriteLine("Content before append:");
            s = File.ReadAllText("ABC.TXT");
            Console.WriteLine(s);

            Console.WriteLine("Enter text to append into file:");
            s = Console.ReadLine();

            File.AppendAllText("ABC.TXT", s);

            Console.WriteLine("Content after append:");
            s = File.ReadAllText("ABC.TXT");
            Console.WriteLine(s);

        }
    }
}