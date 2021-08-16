using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseC
{
    class q5
    {
        static void Main()
        {   
            //Local variables
            int n, i = 0;
            double result=0;
            string str_num;

            //Enter the number and store it in a string
            Console.Write("Enter a number :");
            str_num = Console.ReadLine();

            //Loop through every character and get the numerical value
            //Calculate the sum of each digit to the power of length of number string
            while (i < str_num.Length)
            {
                n = str_num[i] - 48;
                result += Math.Pow(n, str_num.Length);
                i++;
            }

            //if the result is same as the number entered it is armstrong
            if( result == Convert.ToDouble(str_num))
            {
                Console.WriteLine("The given number is an armstrong number !");
            }
            else
            {
                Console.WriteLine("The given number is not an armstrong number !");
            }
        }
    }
}
