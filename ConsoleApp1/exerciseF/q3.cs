using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseF
{
    class q3
    {
        static void Main()
        {
            //Local Variables
            int i, j;
            string s,r;
            bool isPalindrome;

            //Ask the user to input a string
            Console.Write("Input the string : ");
            r = Console.ReadLine();

            //Take only the lower case string for the comparison
            s = r.ToLower();

            //Initialize the variables
            i = 0;
            j = s.Length - 1;
            isPalindrome = true;

            //Check if the input string is palindrome 
            //Compare characters from the beginning and end together
            while (i < j)
            {
                //if i encounters spaces or punctuations ignore
                if (s[i]<'a' || s[i]>'z')                   
                {
                    i++;
                }
                //if j encounters spaces or punctuations ignore
                else if (s[j] < 'a' || s[j] > 'z')
                {
                    j--;
                }
                //if only alphabets are present at i & j then compare
                else if (s[i] != s[j])
                {
                    isPalindrome = false;
                    break;
                }
                //if char at i & j are same then increment or decrement i & j
                else if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
            }

            //If palindrome output accordingly
            if (isPalindrome)
            {
                Console.WriteLine($"{r} ----> is Palindrome");
            }
            else Console.WriteLine($"{r} ----> is not Palindrome");

        }
    }
}
