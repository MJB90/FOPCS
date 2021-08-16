using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseE
{
    class q3
    {
        static void Main()
        {
            int n,i;
            bool isPrime = true;
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            if(n==1 || n == 0)
            {
                isPrime = false;
            }
            else
            {
                for (i = n / 2 ; i >= 2; i--)
                {
                    if(n%i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if(isPrime == true)
            {
                Console.WriteLine("The entered number is prime!");
            }
            else
            {
                Console.WriteLine("The entered number is not prime!");
            }

        }
    }
}
