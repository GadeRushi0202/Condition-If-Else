using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice:-");
            int ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number:-");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number:-");
            int b = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                int add = a + b;
                Console.WriteLine("Addition:-" + add);
            }
            if (ch == 2)
            {
                int add = a - b;
                Console.WriteLine("Substraction:-" + add);
            }
            if (ch == 3)
            {
                int add = a * b;
                Console.WriteLine("Multiplication:-" + add);
            }
            if (ch == 4)
            {
                int add = a / b;
                Console.WriteLine("Divison:-" + add);
            }
        }
    }
}
