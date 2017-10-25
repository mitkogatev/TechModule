using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FixEmails
{
    class FixEmails
    {
        static Dictionary<string, string> mailBook = new Dictionary<string, string>();
        static string name = string.Empty;
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"..\..\tests\input.txt");

            foreach (var line in lines)
            {
                if (line == "stop")
                    PrintResult();
                else if (line == String.Empty || line == null) End();
                else
                    Update(line);
            }
            End();
        }

        private static void PrintResult()
        {
            if (mailBook.Count == 0) return;
                //if (!line.ToLower().EndsWith("us") && !line.ToLower().EndsWith("uk"))
                
                var result = mailBook
                .Where(r=> !r.Value.ToLower()
                .EndsWith("us") && 
                !r.Value.ToLower().EndsWith("uk"))
                .Select(r => r.Key + " -> " + r.Value)
                .ToArray();
            File.AppendAllLines(@"..\..\tests\output.txt", result);
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });
            mailBook.Clear();
            name = string.Empty;
        }

        private static void Update(string line)
        {
            if (line.Contains("@"))
            {
                
                    if (mailBook.ContainsKey(name)) mailBook[name] = line;
                
            }
            else
            {
                if (!mailBook.ContainsKey(line))
                    mailBook.Add(line, null);
                name = line;
            }
        }

        private static void End()
        {
            Process.Start(@"..\..\tests\output.txt");
        }
    }
}
