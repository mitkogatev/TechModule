using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.InstructionSet_Debug
{
    class InstructionSetDebug
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();

            while (opCode != "END")//this must be UC
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0; //+ cast the ops to long
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = (long)operandOne+1;//++ op incements the original var
                            break;
                        }
                    case "DEC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = (long)operandOne-1; //same as ++
                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = (long)operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = (long)operandOne * operandTwo; //cast one op and the result will be long
                            break;
                        }
                }
                Console.WriteLine(result);
                //Reread opCode
                opCode = Console.ReadLine();
            }
        }
    }
}
