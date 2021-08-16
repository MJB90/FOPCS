using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.loop
{
    class q1
    {
        static void Main()
        {
            int j,m = 2,k=10, result = 0;
            for (j = 1; j <= k; j++)
            {
                result = result + m;
            }
            Console.WriteLine("Result : " + result);
            
        }
    }
}
