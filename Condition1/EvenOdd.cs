using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:_");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number:");
            }
            else
            {
                Console.WriteLine("Odd Number");

            }
        }
    }
}
