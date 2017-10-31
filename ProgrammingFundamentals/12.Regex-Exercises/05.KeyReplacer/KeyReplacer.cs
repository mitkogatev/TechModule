using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();
            string[] keySpl = key.Split(new char[] { '|', '<', '\\' },StringSplitOptions.RemoveEmptyEntries);
            string start=keySpl.First();
            string end = keySpl.Last();
            StringBuilder result = new StringBuilder();
            foreach (Match m in Regex.Matches(text,$@"{start}(.*?){end}"))
            {
                result.Append(m.Groups[1].Value);
            }
            if (result.Length==0)
            {
                Console.WriteLine("Empty result");
            }
            else
                Console.WriteLine(result);
        }
    }
}
