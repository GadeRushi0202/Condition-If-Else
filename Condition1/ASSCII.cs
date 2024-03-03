using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class ASSCII
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Char");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
                Console.WriteLine(ch);
            }
            else
            {
                ch = (char)(ch - 32);
                Console.WriteLine(ch);
            }
        }
    }
}
