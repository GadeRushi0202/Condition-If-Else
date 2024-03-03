using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class SwapWithoutThirdNumber
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;

            if (a > b)
            {
                a = a + b; //30+20 = 50
                b = a - b; //50-20 = 30
                a = b - a; //30-50 = 20
            }
            Console.WriteLine("the first Number" + a); //20
            Console.WriteLine("The Sedcond Number" + b); //30

        }
    }
}
