using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int combos = 0;
            int sum = 0;
            for (int i = num1; i > 0; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    sum += (i * j) * 3;
                    combos++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{combos} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combos} combinations");
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
