using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Character:-");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'o' || ch == 'i' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Not Vowel");
            }
        }
    }
}
