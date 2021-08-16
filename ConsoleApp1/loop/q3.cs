using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.loop
{
    class q3
    {
        static void Main()
        {
            int i, j , result = 0;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    result = result + (i * j);
                }
            }
            Console.WriteLine("Result :" + result);
        }
    }
}
