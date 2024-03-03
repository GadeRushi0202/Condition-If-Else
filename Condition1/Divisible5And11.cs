using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class Divisible5And11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 5 == 0 && Number % 11 == 0)
            {
                Console.WriteLine("Divisible By 5 And 11");
            }
            else
            {
                Console.WriteLine("Not Divisible By 5 And 11");
            }

        }
    }
}
