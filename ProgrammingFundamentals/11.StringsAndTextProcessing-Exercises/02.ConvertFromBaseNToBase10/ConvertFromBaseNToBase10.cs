using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _02.ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');//.Select(BigInteger.Parse).ToArray();
            //int length = input[1].Length;
            List<string> target = input[1].ToCharArray().Select(c=>c.ToString()).ToList();
            int toBase = int.Parse(input[0]);
            //StringBuilder str = new StringBuilder();
            
            BigInteger sum = 0;
            int raise = 0;
            while (target.Count > 0)
            {
                sum += int.Parse(target.Last()) * BigInteger.Pow(toBase, raise);
                raise++;
                target.RemoveAt(target.Count - 1);
            }

            //string result = sum.ToString().TrimStart('0');
            //Console.WriteLine("{0}", result != string.Empty ? result : "0");
            Console.WriteLine(sum);

        }
    }
}
