using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int runner1 = int.Parse(Console.ReadLine());
            int runner2 = int.Parse(Console.ReadLine());
            int runner3 = int.Parse(Console.ReadLine());

            int allRunners = runner1 + runner2 + runner3;

            int minutes = 0;

        
             if (allRunners >= 60 && allRunners <= 119)
            {
                minutes++;
               allRunners -= 60;

            }
            else if (allRunners >= 120 && allRunners <= 179)
            {
                minutes+=2;
                allRunners -= 120;
            }
             if (allRunners < 10)
            {

                Console.WriteLine(minutes + ":" + "0" + allRunners);
            }
             else
            {
                Console.WriteLine(minutes + ":" + allRunners);
            }
        }
    }
}
