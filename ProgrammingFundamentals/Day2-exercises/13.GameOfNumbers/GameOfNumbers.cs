using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combos = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    combos++;
                    if (j + i == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combos} combinations - neither equals {magicNum}");
        }
    }
}
