using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {name} {family}. You are {age} years old.");
        }
    }
}
