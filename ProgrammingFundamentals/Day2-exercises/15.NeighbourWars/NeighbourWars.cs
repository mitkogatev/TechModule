using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int pDamage = int.Parse(Console.ReadLine());
            int gDamage = int.Parse(Console.ReadLine());
            int pHp = 100;
            int gHp = 100;
            int turns = 0;

            while (true)
            {
                turns++;
                if (turns % 2 == 0)
                {
                    pHp -= gDamage;
                    if (pHp <= 0) { break; }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pHp} health.");
                }
                else
                {
                    gHp -= pDamage;
                    if (gHp <= 0) { break; }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {gHp} health.");
                }
                //if (gHp <= 0 || pHp <= 0)
                //{
                //    break;
                //}
                if (turns % 3 == 0)
                {
                    pHp += 10;
                    gHp += 10;
                }
            }
            Console.WriteLine("{0} won in {1}th round.",pHp<=0? "Gosho":"Pesho",turns );

        }
    }
}
