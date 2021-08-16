using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q4
    {
        static string Substitute(String s, char c1, char c2)
        {
            int i;
            StringBuilder sb = new StringBuilder(s);

            for (i = 0; i < sb.Length; i++)
            {
                if (sb[i] == c1)
                {
                    sb[i] = c2;
                }
            }
            return sb.ToString();
        }

        static void Main()
        {
            string s = "Good morning everyone, Hope you have a great day ahead!";
            char c1 = 'o';
            char c2 = '@';
            Console.WriteLine($"String before substitution : {s}");
            Console.WriteLine("String after substitution : "+ Substitute(s, c1, c2));
        }
    }
}
