using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> legendaries = new Dictionary<string, string>
            {{"shards","Shadowmourne"},{"fragments","Valanyr"},{"motes","Dragonwrath"} };
            Dictionary<string, int> materials = new Dictionary<string, int> {
                {"shards",0 },{"fragments",0 },{"motes",0} };
            Dictionary<string, int> junks = new Dictionary<string, int> { };

            while (true)
            {
                string[] line = Console.ReadLine().ToLower().Split(' ');
                for (int i = 1; i < line.Length; i += 2)//each odd key
                {
                    string currMat = line[i];
                    int currVal = int.Parse(line[i - 1]);
                    if (materials.ContainsKey(currMat))
                    {
                        materials[currMat] += currVal;
                    }
                    else //junk
                    {
                        if (!junks.ContainsKey(currMat))
                            junks.Add(currMat, currVal);
                        else
                            junks[currMat] += currVal;
                    }

                    if (materials.Values.Max() >= 250)
                    {
                        break;
                    }
                }
                if (materials.Values.Max() >= 250)
                    break;
            }
            Console.WriteLine();
            string matKey = materials.First(m => m.Value >= 250).Key;
            Console.WriteLine("{0} obtained!",legendaries[matKey]);
            materials[matKey] -= 250;

            foreach (var mat in materials.OrderBy(m=>m.Key).OrderByDescending(m => m.Value))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }
            foreach (var junk in junks.OrderBy(m => m.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
