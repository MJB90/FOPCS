using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class q5
    {
        static void Main()
        {
            Console.Write("Enter a double precision number :");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The number with two precision is {0:0.00}", n);
        }
    }
}
