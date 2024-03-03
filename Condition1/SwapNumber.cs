using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class SwapNumber
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine("First Number A=" + a);
            Console.WriteLine("Second  Number B=" + b);
        }
    }
}
