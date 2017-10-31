using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            v1();
        }
        private static void v3()
        {
            string sentence = Console.ReadLine();
            string pattern = Console.ReadLine();
            string tmp = sentence;
            while (true)
            {
                int firstMatch = tmp.IndexOf(pattern);
                int lastMatch = tmp.LastIndexOf(pattern);
                if (firstMatch == lastMatch || pattern=="")
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                tmp = tmp.Remove(firstMatch, pattern.Length);
                tmp = tmp.Remove(tmp.LastIndexOf(pattern), pattern.Length);


                Console.WriteLine("Shaked it.");
                sentence = tmp;
                pattern = pattern.Remove(pattern.Length / 2, 1);

            }
            Console.WriteLine(sentence);
        }
        private static void v2()
        {
            string sentence = Console.ReadLine();
            string pattern = Console.ReadLine();
            int found = 0;
            string tmp = sentence;
            while (pattern.Length>0)
            {
                int firstMatch = tmp.IndexOf(pattern);
                int lastMatch = tmp.LastIndexOf(pattern);
                if (firstMatch == lastMatch || "".Equals(pattern))
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                
                    tmp = tmp.Remove(firstMatch, pattern.Length);
                    tmp = tmp.Remove(tmp.LastIndexOf(pattern), pattern.Length);
                    
                
                    Console.WriteLine("Shaked it.");
                    sentence = tmp;
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                
            }
            Console.WriteLine(sentence);
        }
        private static void v1()
        {
            string sentence = Console.ReadLine();
            string pattern = Console.ReadLine();
            int found = 0;
            string tmp = sentence;
            while (pattern.Length>0)
            {
                int firstMatch = tmp.IndexOf(pattern);
                if (pattern=="")
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                if (firstMatch != -1)
                {
                    tmp = tmp.Remove(firstMatch, pattern.Length);
                    found++;
                }
                int lastMatch = tmp.LastIndexOf(pattern);
                if (lastMatch != -1)
                {
                    tmp = tmp.Remove(lastMatch, pattern.Length);
                    found++;
                }
                if (found == 2)
                {
                    Console.WriteLine("Shaked it.");
                    sentence = tmp;
                    found = 0;
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }
            Console.WriteLine(sentence);
        }
    }
}
