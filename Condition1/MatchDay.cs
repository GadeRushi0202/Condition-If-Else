using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class MatchDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Sunday");
            }
            else if (a == 1)
            {
                Console.Write("Monday");
            }
            else if (a == 2)
            {
                Console.Write("Tuesday");
            }

            else if (a == 3)
            {
                Console.Write("Wendnesay");
            }

            else if (a == 4)
            {
                Console.WriteLine("Thrusday");
            }
            else if (a == 5)
            {
                Console.Write("Friday");
            }
            else if (a == 6)
            {
                Console.Write("Friday");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
