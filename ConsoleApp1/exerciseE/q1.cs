using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseE
{
    class q1
    {
        static void Main()
        {
            //Local variables
            int inc_result = 1, dec_result = 1, i, n;

            //Ask the user for input
            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

            //Calculate factorial using increment operator
            for (i = 1; i <= n; i++)
            {
                inc_result *= i;
            }

            //Calculate factorial using decrement operator
            for (i = n; i > 0; i--)
            {
                dec_result *= i;
            }

            //Output the result
            Console.WriteLine($"Factorial of {n} using inc operator is {inc_result}");
            Console.WriteLine($"Factorial of {n} using dec operator is {dec_result}");

        }
    }
}
