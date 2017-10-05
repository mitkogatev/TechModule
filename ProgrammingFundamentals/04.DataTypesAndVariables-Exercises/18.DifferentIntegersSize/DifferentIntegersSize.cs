using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                long.Parse(input);
                Console.WriteLine($"{input} can fit in:");
            }
              
            catch
            {
                Console.WriteLine($"{input} can't fit in any type");
                return;
            }
            try { sbyte.Parse(input); Console.WriteLine("* sbyte"); } catch { }
            try { byte.Parse(input); Console.WriteLine("* byte"); } catch { }
            try { short.Parse(input); Console.WriteLine("* short"); } catch { }
            try { ushort.Parse(input); Console.WriteLine("* ushort"); } catch { }
            try { int.Parse(input); Console.WriteLine("* int"); } catch { }
            try { uint.Parse(input); Console.WriteLine("* uint"); } catch { }
            try { long.Parse(input); Console.WriteLine("* long"); } catch { }
        

    }
    }
}
