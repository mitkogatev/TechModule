using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.SequenceOfCommands_Debug
{
    class SequenceOfCommandsDebug
    {
        private const char ArgumentsDelimiter = ' ';
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();
            //renamed command to line
            string line = Console.ReadLine();

            while (!line.Equals("stop"))//stop
            {
                line.Trim();//Console.ReadLine().Trim();
                int[] args = new int[2];
                string[] stringParams = line.Split(ArgumentsDelimiter);
                string command = stringParams[0];
                //StartsWith
                if (command.Equals("add") ||
                    command.Equals("subtract") || //subtract
                    command.Equals("multiply"))
                {
                   // string[] stringParams = line.Split(ArgumentsDelimiter); //moved above
                    args[0] = int.Parse(stringParams[1])-1;//-1
                    args[1] = int.Parse(stringParams[2]);

                    //PerformAction(array, stringParams[0], args);
                }

                PerformAction(array, command, args);

                PrintArray(array);
                Console.WriteLine();//no \n

                line = Console.ReadLine();
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[]; //no need
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastVal = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastVal;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstVal = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstVal;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");//write
            }
        }
    }
}
