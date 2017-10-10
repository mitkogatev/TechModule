using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());

            RotAndSum(numbers, rotationCount);

        }

        private static void RotAndSum(int[] numbers, int rotationCount)
        {
            int[] sum = new int[numbers.Length];
            for (int count = 0; count < rotationCount; count++)
            {
                //rotate
                int lastVal = numbers[numbers.Length - 1];
                for (int j = numbers.Length-1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastVal;
                //sum
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }
            Console.WriteLine(String.Join(" ",sum));
        }
    }
}
