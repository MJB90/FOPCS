using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseB
{
    class q6
    {
        static void Main()
        {
            double x1, x2, y1, y2, d;

            //Fetch x coordinate for point 1
            Console.Write("Enter the x coordinate for point 1 :");
            x1 = Convert.ToDouble(Console.ReadLine());

            //Fetch y coordinate for point 1
            Console.Write("Enter the y coordinate for point 1 :");
            y1 = Convert.ToDouble(Console.ReadLine());

            //Fetch x coordinate for point 2
            Console.Write("Enter the x coordinate for point 2 :");
            x2 = Convert.ToDouble(Console.ReadLine());

            //Fetch y coordinate for point 2
            Console.Write("Enter the y coordinate for point 2 :");
            y2 = Convert.ToDouble(Console.ReadLine());

            //Calculate the distance
            d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Print the distance between the two points
            Console.WriteLine($"The distance between ({x1},{y1}) and ({x2},{y2}) is : " + d);

        }
    }
}
