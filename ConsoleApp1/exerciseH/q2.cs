using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q2
    {
        static void PrintArray(int [] arayElements)
        {
            int i;
            for (i = 0; i < arayElements.Length; i++)
            {
                Console.Write(arayElements[i] + ",");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int[] arrayElements = new int[] { 1, 2, 3, 4, 5 };

            PrintArray(arrayElements);
        }
    }
}
