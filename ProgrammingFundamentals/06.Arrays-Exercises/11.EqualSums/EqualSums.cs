using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lsum = 0;
            int rsum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                lsum = CalcLsum(numbers, i);
                rsum = CalcRsum(numbers, i);
                
                if (lsum == rsum)
                {
                    Console.WriteLine(i);
                    return;
                }
                lsum = 0;
                rsum = 0;
            }
            Console.WriteLine("no");
        }

        private static int CalcRsum(int[] numbers, int index)
        {
            int sum = 0;
            for (int i = index+1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static int CalcLsum(int[] numbers, int index)
        {
            int sum=0;
            for (int i = index-1; i >= 0; i--)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
