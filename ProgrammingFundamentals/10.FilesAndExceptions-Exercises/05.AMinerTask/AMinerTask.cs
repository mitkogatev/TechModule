using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AMinerTask
{
    class AMinerTask
    {
        static Dictionary<string, long> resources = new Dictionary<string, long>();
        static string name = string.Empty;
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"..\..\tests\input.txt");
            
            foreach (var line in lines)
            {
                if (line == "stop")
                    PrintResult();
                else if (line == String.Empty||line==null) return;
                else
                Update(line);
            }
            PrintResult();
        }

        private static void PrintResult()
        {
            if (resources.Count == 0) return;
            var result = resources.Select(r => r.Key+" -> "+r.Value).ToArray();
            File.AppendAllLines(@"..\..\tests\output.txt",  result);
            File.AppendAllLines(@"..\..\tests\output.txt", new string[] { "END of Test" });
            resources.Clear();
            name = string.Empty;
        }

        private static void Update(string line)
        {
            try
            {
                int qty = int.Parse(line);
                if (resources.ContainsKey(name))
                    resources[name] += qty;
            }
            catch
            {
                name = line;
                if (!resources.ContainsKey(name))
                    resources.Add(name, 0);
            }
        }
    }
}
