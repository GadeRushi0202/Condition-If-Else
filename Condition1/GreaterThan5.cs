using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class GreaterThan5
    {
        //Write a program to input a number and check whether it is greater than 5 or not.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num > 5)
            {
                Console.WriteLine("greater than 5");
            }
            else
            {
                Console.WriteLine("no greater than 5");
            }
        }
    }
}
