using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> usersLog = new SortedDictionary<string, Dictionary<string, int>>();
            
            while (line != "end")
            {
                string[] parsedLine = Regex.Split(line, @"=|\s");
                //1=ip;5=username
                string user = parsedLine[5];
                string ip = parsedLine[1];
                //create user if not exists, and add ip
                if (usersLog.ContainsKey(user))
                {
                    //update
                    if (usersLog[user].ContainsKey(ip))
                        usersLog[user][ip]++;
                    else
                        usersLog[user][ip] = 1;
                }
                else
                    usersLog[user] = new Dictionary<string, int> { { ip, 1 } };
             line = Console.ReadLine();

            }
            foreach (var user in usersLog)
            {
                Console.WriteLine(user.Key+": ");

                foreach (var ip in user.Value)
                {
                    string endChar = ", ";
                    if (ip.Key == user.Value.Last().Key)
                        endChar = ".";
                    Console.Write("{0} => {1}{2}",ip.Key,ip.Value,endChar);
                }
                Console.WriteLine();
            }

            
        }
    }
}
