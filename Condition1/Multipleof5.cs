using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class Multipleof5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num % 5 == 0)
            {
                Console.WriteLine("Multiple By 5");
            }
            else
            {
                Console.WriteLine("Not Multiole By 5");
            }
        }
    }
}
