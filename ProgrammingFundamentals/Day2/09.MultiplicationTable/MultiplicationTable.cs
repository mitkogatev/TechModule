using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            // V2.0
            int num=int.Parse(Console.ReadLine());
            int mul=int.Parse(Console.ReadLine());

            if (mul > 10)
            {
                Console.WriteLine($"{num} X {mul} = {num * mul}");
            }
            else
            {
                for (int i = mul; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }
            // V 1
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{num} X {i} = {num*i}");
            //}
        }
    }
}
