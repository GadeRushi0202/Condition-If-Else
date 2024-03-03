using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class CheckAlphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("The Character Alphabet");
            }

            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("The Character is digit");
            }
            else
            {
                Console.WriteLine("The Character is Special Character");
            }
        }
    }
}
