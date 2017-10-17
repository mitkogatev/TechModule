using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            //{type} {name} {damage} {health} {armor}
            //health 250, damage 45, and armor 10
            //type(u),name(u),stats
            int dragonsCount = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            for (int i = 0; i < dragonsCount; i++)
            {
                string[] lineArgs = Console.ReadLine().Split(' ');
                //0=type;1=name;2=dmg;3=hp;4=arm;
                string type = lineArgs[0];
                string name = lineArgs[1];
                string[] strStats = lineArgs.Skip(2).ToArray();
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, int[]> { { name, ValidateStats(strStats) } });
                }
                else
                {
                    if (dragons[type].ContainsKey(name))
                        dragons[type][name] = ValidateStats(strStats);
                    else
                        dragons[type].Add(name, ValidateStats(strStats));
                }
            }
            //
            foreach (var type in dragons)
            {
                double avgDmg = type.Value.Values.Select(i=>i[0]).Average();
                double avgHp = type.Value.Values.Select(i=>i[1]).Average();
                double avgArm = type.Value.Values.Select(i=>i[2]).Average();
                Console.WriteLine($"{type.Key}::({avgDmg:F2}/{avgHp:F2}/{avgArm:F2})");
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }

        private static int[] ValidateStats(string[] strStats)
        {
            //0=dmg;1=hp;2=arm;
            int[] stats = new int[] {45,250,10};
            //try {int.Parse(strStats[0])}
            for (int i = 0; i < 3; i++)
            {
                try { stats[i] = int.Parse(strStats[i]); } catch { }
            }
            return stats;
        }
    }
}
