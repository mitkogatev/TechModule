using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            for (int num = 232; num <= endNumber; num++)
            {
                if (ContainsEvenDigit(num))
                {
                    if (SumOfDigits(num))
                    {
                         if (IsPalindrome(num))
                            {
                                Console.WriteLine(num);
                            }
                    }
                }
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            bool containsEven = false;
            while (num > 0)
            {
                if ((num % 10) % 2 == 0) containsEven = true;
                num /= 10;
            }
            return containsEven;

        }

        private static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum+=(num % 10);
                num /= 10;
            }
            if (sum % 7 == 0) return true;
            else return false;
            
        }

        private static bool IsPalindrome(int num)
        {
            string strNum = num + "";
            string revNum = new string(strNum.Reverse().ToArray());
            if (strNum == revNum) { return true; }
            else return false;
        }

    }
}
