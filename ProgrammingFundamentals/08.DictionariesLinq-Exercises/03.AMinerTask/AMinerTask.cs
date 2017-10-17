using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int> { };
            while (line !="stop")
            {
                string key = line;
                int value = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(key))
                    resources[key] += value;
                else
                    resources[key] = value;
                
                line = Console.ReadLine();
            }
            foreach (var res in resources)
            {
                Console.WriteLine("{0} -> {1}",res.Key,res.Value);
            }
        }
    }
}
