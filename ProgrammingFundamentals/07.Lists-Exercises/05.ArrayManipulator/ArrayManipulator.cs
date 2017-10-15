using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string line = Console.ReadLine();
            while (line != "print")
            {
                Manipulate(line,numbers);
                line = Console.ReadLine();
            }
            Console.WriteLine("["+String.Join(", ",numbers)+"]");
        }

        private static void Manipulate(string line, List<int> numbers)
        {
            string[] args = line.Split(' ').ToArray();
            int[] values = args.Skip(1).Select(int.Parse).ToArray();
            

            if (args[0] == "add")
            {
                numbers.Insert(values[0], values[1]);
            }
            else if (args[0] == "addMany")
            {
                numbers.InsertRange(values[0], values.Skip(1));
            }
             if (args[0] == "contains")
            {
                int foundAtindex = numbers.FindIndex(x => x == values[0]);
                Console.WriteLine(foundAtindex);
            }
             if (args[0] == "remove")
            {
                numbers.RemoveAt(values[0]);
            }
             if (args[0] == "shift")
            {
                var count = values[0] % numbers.Count;
                for (int i = 0; i < count; i++)
                {
                    var el = numbers[i];
                    numbers.RemoveAt(0);
                    numbers.Add(el);
                }

            }
            if (args[0] == "sumPairs")
            {
                List<int> sum = new List<int> (numbers);
                numbers.Clear();
                for (int i = 0; i < sum.Count; i+=2)
                {
                    numbers.Add(sum.Skip(i).Take(2).Sum());
                }

            }
        }

        private static List<int> Shift(List<int> numbers, int pos)
        {
            var tmp = new List<int>(numbers);
            var count = pos% numbers.Count;
            for (int i = 0; i < count; i++)
            {
                var el = numbers[i];
                tmp.RemoveAt(0);
                tmp.Add(el);
            }

            return tmp;
        }
    }
}
