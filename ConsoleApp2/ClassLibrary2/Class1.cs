using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aboba
{
    public class Class1
    {
        public static void SumFunc(double c, double b)
        {
            double Cul = c * b + 2 * c; 
            double Sum = c + b;
            double Mult = c * b;
            Console.WriteLine("Summ = {0} Multiply= {1} Cult= {2}", Sum, Mult, Cul);
            Console.ReadLine();
        }
    }
}

