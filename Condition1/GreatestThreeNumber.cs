using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class GreatestThreeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number:-");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Second Number:-");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a thrid Number:-");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine("Num1 Is Greater");
            }
            else if (Num2 > Num3 && Num2 > Num1)
            {
                Console.WriteLine("Num2 Is Greater");
            }
            else
            {
                Console.WriteLine("Num3 Is Greater");
            }
        }
    }
}
