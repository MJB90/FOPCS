using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseE
{
    class q6
    {
        static bool CheckPerfectNumber(int n)
        {
            //Local variables
            int i, sum_of_factors = 0;
            
            //find all the factors of n and calculate the sum of factors
            for (i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum_of_factors += i;
                }
            }

            //if the sum of factors is the number itself then return true else return false
            if (sum_of_factors == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            //Local variables
            int lower_limit, upper_limit;

            //Ask for the lower limit
            Console.Write("Enter the positive lower limit : ");
            lower_limit = Convert.ToInt32(Console.ReadLine());

            //Ask for the upper limit
            Console.Write("Enter the positive upper limit : ");
            upper_limit = Convert.ToInt32(Console.ReadLine());

            //Output all the prime numbers between lower limit and upper limit
            Console.WriteLine($"The perfect numbers between {lower_limit} and {upper_limit} are as follows: ");
            for (; lower_limit <= upper_limit; lower_limit++)
            {
                if (CheckPerfectNumber(lower_limit))
                {
                    Console.Write(lower_limit + ",");
                }
            }
            Console.WriteLine();
        }
    }
}
