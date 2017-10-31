using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            string longest = string.Empty;
            string shortest = string.Empty;
            if (num1.Length >= num2.Length)
            {
                longest = num1;
                shortest = num2;
            }
            else
            {
                longest = num2;
                shortest = num1;
            }
            int diff = longest.Length - shortest.Length;
            shortest=shortest.PadLeft(shortest.Length + diff, '0');
            
            StringBuilder tmpResult = new StringBuilder();
            int sum = 0;
            for (int i = longest.Length-1; i >= 0; i--)
            {
                sum += int.Parse(longest[i].ToString()) + int.Parse(shortest[i].ToString());
                if (sum > 9)
                {
                    tmpResult.Insert(0,sum % 10);
                    sum = sum / 10;
                }
                else
                {
                    tmpResult.Insert(0,sum);
                    sum = 0;
                }
            }
            if(sum>0) tmpResult.Insert(0, sum);

            string result = tmpResult.ToString().TrimStart('0');
            Console.WriteLine("{0}",result!=string.Empty?result:"0");
            //BigInteger n = BigInteger.Parse(num1);
            //BigInteger m = BigInteger.Parse(num2);
            //Console.WriteLine(n+m);

           // Console.WriteLine(new string('1',50));
        }
    }
}
