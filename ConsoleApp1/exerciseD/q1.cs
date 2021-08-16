using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseD
{
    class q1
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please enter an integer: ");
                if(Convert.ToInt32(Console.ReadLine())== 88)
                {
                    Console.WriteLine("Lucky you...");
                    break;
                }
            }
        }
    }
}
