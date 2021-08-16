using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.loop
{
    class q2
    {
        static void Main()
        {
            int j = 1, i = 1;
            while (j <= 5)
            {
                i = i * j;
                j++;
            }
            Console.WriteLine("i : " + i);
        }
    }
}
