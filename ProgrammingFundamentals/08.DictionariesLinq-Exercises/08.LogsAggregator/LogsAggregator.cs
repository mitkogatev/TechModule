using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int logsCount = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < logsCount; i++)
            {
                string[] lineArgs = Console.ReadLine().Split(' ');
                string user = lineArgs[1];
                string ip = lineArgs[0];
                int dur = int.Parse(lineArgs[2]);

                if (!logs.ContainsKey(user))
                    logs.Add(user, new SortedDictionary<string, int> { { ip, dur } });
                else
                {
                    if (!logs[user].ContainsKey(ip))
                        logs[user].Add(ip, dur);
                    else
                        logs[user][ip] += dur;
                }
            }

            foreach (var username in logs)
            {
                Console.WriteLine("{0}: {1} [{2}]",username.Key,username.Value.Values.Sum(), string.Join(", ", username.Value.Keys));
            }
        }
    }
}
