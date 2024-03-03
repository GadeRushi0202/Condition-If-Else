using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition1
{
    internal class Electricity_Bill
    {
        static void Main(string[] args)
        {
            double Bill = 0;
            Console.WriteLine("Enter Your Eletricity unit:-");
            int unit = Convert.ToInt32(Console.ReadLine());
            if (unit < 50)
            {
                Bill = Bill + (0.50 * unit);
            }
            else if (unit > 50 && unit < 100)
            {
                Bill = Bill + (0.75 * unit);
            }
            else if (unit > 100 && unit < 200)
            {
                Bill = Bill + (1.20 * unit);
            }
            else if (unit > 200 && unit < 250)
            {
                Bill = Bill + (1.50 * unit);
            }
            Console.WriteLine("Total Eletricicty Bill is :-" + Bill);
        }
    }
}
