using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class ThreeNumbersCompare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Second  Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Third Number");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine("The Num1 is greater");
            }
            else if (Num2 > Num3)
            {
                Console.WriteLine("The Num2 is greater");
            }
            else
            {
                Console.WriteLine("The Num3 is greater");
            }


        }
    }
}
