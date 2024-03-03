using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class LeapYear
    {
        //Write a program to check whether a year is leap year or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year :-");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0))
            {

                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
    }
}
