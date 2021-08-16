using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q3
    {
        //Method to convert integer to hexadecimal string
        static string ConvertToHexa(int n)
        {
            //Local variables
            string hexa = "";
            int remainder;

            //take the remainder and add to string hexa accordingly
            while (n != 0)
            {
                remainder = n % 16;

                switch (remainder)
                {
                    case 10: hexa += 'A'; break;
                    case 11: hexa += 'B'; break;
                    case 12: hexa += 'C'; break;
                    case 13: hexa += 'D'; break;
                    case 14: hexa += 'E'; break;
                    case 15: hexa += 'F'; break;
                    default: hexa += remainder; break;
                }

                n = n / 16; //quotient
            }

            //Reverse the string as we have obtained the result in the reverse order
            return new string(hexa.ToCharArray().Reverse().ToArray());
        }
        static void Main()
        {
            int i;

            Console.WriteLine("Integer\tUser Conversion\t System Conversion");
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i}\t\t" + ConvertToHexa(i) + "\t\t" + Convert.ToString(i, 16).ToUpper());
            }
        }
    }
}
