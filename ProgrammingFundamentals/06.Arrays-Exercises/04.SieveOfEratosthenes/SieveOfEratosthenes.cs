using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());

            bool[] primes = new bool[endRange+1];
            //assign true
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int i = 2; i <= Math.Sqrt(endRange); i++)
            {
                if (primes[i] == true)
                {
                    //Console.Write(i + " ");
                    for (int j = i*i; j < primes.Length; j+=i)
                    {
                        primes[j] = false;
                    }
                }
            }
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true) Console.Write(i+" ");
            }

            
            Console.WriteLine();
        }
    }
}
