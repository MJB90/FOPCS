using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseD
{
    class q2
    {
        static void Main()
        {
            //Local variables
            int a, b, tempA, tempB;

            //Ask the user for A
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());

            //Ask the user for B
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Store a copy to calculate the LCM
            tempA = a;
            tempB = b;

            //Keep subtacting smaller from greater number until both numbers are equal
            while(a!=b)
            {
                if (a < b)
                {
                    b = b - a;
                }
                else a = a - b;
            }

            //If the numbers are equal output the HCF & LCM
            if( a == b)
            {
                Console.WriteLine("The HCF is : " + a);
                Console.WriteLine("The LCM is : {0}", (tempA * tempB) / a);
            }

        }
    }
}
