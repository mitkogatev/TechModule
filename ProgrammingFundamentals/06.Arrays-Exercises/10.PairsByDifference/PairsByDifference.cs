using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            Compare(numbers,diff);
            //int count = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        if (Math.Abs(numbers[i]-numbers[j])==diff)
            //        {
            //            count++;
            //        }
            //    }
            //    numbers[i] = int.MaxValue;

            //}
            //Console.WriteLine(count);
        }

        private static void Compare(int[] numbers,int diff)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == diff) { count++; }
                    //Console.WriteLine($"i={i} j={j} diff={Math.Abs(numbers[i]-numbers[j])}");
                }
            }
            Console.WriteLine(count);
        }
    }
}
