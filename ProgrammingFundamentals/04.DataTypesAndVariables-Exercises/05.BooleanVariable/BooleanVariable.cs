using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine("{0}",Convert.ToBoolean(input)==true?"Yes":"No");
        }
    }
}
