using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            int sum = 0;
            StringBuilder tmpResult = new StringBuilder();
            for (int i = num1.Length-1; i >= 0; i--)
            {
                int currNum = int.Parse(num1[i].ToString());
                //if()
                sum += currNum * multiplier;//currNum!=0?currNum * multiplier:multiplier;
                if (sum > 9)
                {
                    tmpResult.Insert(0, sum % 10);
                    sum /= 10;
                }
                else
                {
                    tmpResult.Insert(0, sum);
                    sum = 0;
                }
            }
            if (sum>0)
                tmpResult.Insert(0, sum);
            //Console.WriteLine(tmpResult);
            string result = tmpResult.ToString().TrimStart('0');
            Console.WriteLine("{0}", result != string.Empty ? result : "0");

        }
    }
}
