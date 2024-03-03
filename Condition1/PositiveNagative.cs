using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class PositiveNagative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Positive NUmber");
            }
            else if (a < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero Number");
            }
        }
    }
}
