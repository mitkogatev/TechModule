using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailList = new Dictionary<string, string> { };
            string line = Console.ReadLine();
            while (line != "stop")
            {
                string name = line;
                string email = Console.ReadLine();
                if (!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk"))
                {
                    mailList[name] = email;
                }
                line = Console.ReadLine();
            }
            foreach (var entry in mailList)
            {
                Console.WriteLine("{0} -> {1}",entry.Key,entry.Value);
            }
        }
    }
}
