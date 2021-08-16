using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseE
{
    class q5
    {
        /*Method to check if a number is prime
         Input  :  integer
         Output :  boolean
         */
        static bool CheckPrime(int n)
        {
            //Local variables
            int i;
            
            //Check for corner cases
            if (n == 1 || n == 0 || n < 0 )
            {
                return false;
            }
            else
            {
                //Check if the number has any factors other than itself
                for (i = n / 2; i >= 2; i--)
                {
                    if (n % i == 0)
                    {
                        //return false if there is a factor
                       return false;
                  
                    }
                }
            }

            //The number is prime if there are no factors
           return true;
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
            Console.WriteLine($"The prime numbers between {lower_limit} and {upper_limit} are as follows: ");
            for (; lower_limit <= upper_limit; lower_limit++)
            {
                if (CheckPrime(lower_limit))
                {
                    Console.Write(lower_limit + ",");
                }
            }
            Console.WriteLine();
        }
    }
}