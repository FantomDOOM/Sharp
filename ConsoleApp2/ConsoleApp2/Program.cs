using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aboba;

namespace Minecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, n;
            h = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToDouble(Console.ReadLine());
            Class1.SumFunc(h, n); 
        }
    }
}


