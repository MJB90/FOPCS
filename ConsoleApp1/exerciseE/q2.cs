using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseE
{
    class q2
    {
        static void Main()
        {
            double i = 1;
            Console.WriteLine("NO\tINVERSE\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("------------------------------------------------");
            while (i <= 10)
            {
                Console.WriteLine("{0:0.0}\t{1:#.0##}\t{2:#.0##}\t\t{3:0.0}", i, 1 / i, Math.Sqrt(i), Math.Pow(i, 2));
                i++;
            }
        }
    }
}
