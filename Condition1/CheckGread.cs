using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class CheckGread
    {
        static void Main(string[] args)
        {
            //3.Accept marks of 3 subjects physics, chemistry, maths out of 100.Calculate percentage.
            //Display grade as below.
            //Percentage > 80 % -Grade A
            //Percentage > 70 % -Grade B
            //Percentage > 60 % -Grade C
            //Percentage < 60 % -Grade D

            Console.WriteLine("Enter Your physics Mark1");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your chemistry Mark");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your maths mark");
            int maths = Convert.ToInt32(Console.ReadLine());

            int totalMark = physics + chemistry + maths;
            double result = (totalMark / 300.0) * 100;
            Console.WriteLine(totalMark);
            Console.WriteLine(result);

            if (result > 80)
            {
                Console.WriteLine("Gread A");
            }
            else if (result > 70)
            {
                Console.WriteLine("Gread B");
            }
            else if (result > 60)
            {
                Console.WriteLine("Gread c");
            }
            else
            {
                Console.WriteLine("Grade D");
            }
            Console.ReadLine();

        }
    }
}
