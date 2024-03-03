using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class MaximumNumber
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if (a > b && a > c)
            {
                Console.WriteLine(" A is Maximum NUmber");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("B is Maximum Number");
            }
            else
            {
                Console.WriteLine("C is MAximum Number");
            }
        }
    }
}
