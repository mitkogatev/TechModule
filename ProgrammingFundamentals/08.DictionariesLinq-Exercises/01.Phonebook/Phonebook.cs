using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, string> phoneBook = new Dictionary<string, string> { };
            while (line != "END")
            {
                string[] cmd = line.Split(' ');
                if (cmd[0] == "A")
                {
                    phoneBook[cmd[1]]= cmd[2];
                }
                if (cmd[0] == "S")
                {
                    Console.WriteLine("{0}",phoneBook.ContainsKey(cmd[1])? cmd[1]+ " -> "+ phoneBook[cmd[1]]: "Contact "+cmd[1]+" does not exist.");
                }
                line = Console.ReadLine();
            }
        }
    }
}

