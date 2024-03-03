using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class Reactangle
    {
        //accept length and breath of a reactagle and find perimeter in c#
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Breath");
            double Breath = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a Leanth");
            double Leanth = Convert.ToDouble(Console.ReadLine());

            double area = Leanth * Breath;
            Console.WriteLine("Area " + area);

            Double perimeter = 2 * (Leanth + Breath);
            Console.WriteLine("perimeter" + perimeter);
        }
    }
}
