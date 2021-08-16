using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseF
{
    class q2
    {
        static void Main()
        {
            //Local Variables
            int i, j;
            string s;
            bool isPalindrome;

            //Ask the user to input a string
            Console.Write("Input the string : ");
            s = Console.ReadLine();

            //Initialize the variables
            i = 0;
            j = s.Length - 1;
            isPalindrome = true;

            //Check if the input string is palindrome 
            //Compare characters from the beginning and end together
            while(i<s.Length && j >= 0)
            {
                if (s[i] != s[j])
                {
                    isPalindrome = false;
                    break;
                }
                i++;
                j--;
            }

            //If palindrome output accordingly
            if (isPalindrome)
            {
                Console.WriteLine($"{s} is Palindrome");
            }
            else Console.WriteLine($"{s} is not Palindrome");

        }
    }
}
