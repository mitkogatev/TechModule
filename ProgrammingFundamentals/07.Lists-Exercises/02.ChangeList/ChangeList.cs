using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                if (command.StartsWith("Delete"))
                {
                    string[] line = command.Split(' ').ToArray();
                    int value = int.Parse(line[1]);
                    numbers.RemoveAll(x=>x==value);
                }
                if (command.StartsWith("Insert"))
                {
                    string[] line = command.Split(' ').ToArray();
                    int value = int.Parse(line[1]);
                    int index = int.Parse(line[2]);
                    numbers.Insert(index,value);
                }
                command = Console.ReadLine();
            }
            if (command == "Odd")
            {
                Console.WriteLine(String.Join(" ",numbers.Where(x=>x%2!=0)));
            }
            if (command == "Even")
            {
                Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
        }
    }
}
