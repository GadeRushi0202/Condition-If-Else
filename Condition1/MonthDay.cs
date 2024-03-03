using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class MonthDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Month Number");
            int Month = Convert.ToInt32(Console.ReadLine());

            if (Month == 1)
            {
                Console.WriteLine("January = 31 Days");
            }
            else if (Month == 2)
            {
                Console.WriteLine("February = 28/29 Days");
            }
            else if (Month == 3)
            {
                Console.WriteLine("March = 31 Days");
            }
            else if (Month == 4)
            {
                Console.WriteLine("April = 30 Days");
            }
            else if (Month == 5)
            {
                Console.WriteLine("May = 31 Days");
            }
            else if (Month == 6)
            {
                Console.WriteLine("June = 30 Dyas");
            }
            else if (Month == 7)
            {
                Console.WriteLine("July = 31 Days");
            }
            else if (Month == 8)
            {
                Console.WriteLine("August = 31 Days");
            }
            else if (Month == 9)
            {
                Console.WriteLine("September = 30 Days");
            }
            else if (Month == 10)
            {
                Console.WriteLine("October = 31 Days");
            }
            else if (Month == 11)
            {
                Console.WriteLine("November = 30 Days");
            }
            else if (Month == 12)
            {
                Console.WriteLine("December = 31 Days");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
