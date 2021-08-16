using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseE
{
    class q4
    {
        static void Main()
        {
            int n, i, sum_of_factors = 0;
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum_of_factors += i;
                }
            }

            if(sum_of_factors == n)
            {
                Console.WriteLine($"{n} is a perfect number!");
            }
            else
            {
                Console.WriteLine($"{n} is not a perfect number!");
            }
        }
    }
}
