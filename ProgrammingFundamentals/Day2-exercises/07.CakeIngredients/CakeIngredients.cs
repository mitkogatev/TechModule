using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string input = "";
            int count = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Bake!") break;
                Console.WriteLine("Adding ingredient "+input+".");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
