using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q9
    {
        delegate double DoubleOps(double x);

        static double PerformSqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static double PerformSquare(double x)
        {
            return Math.Pow(x,2);
        }

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] result = new double[arr.Length];
            int i;

            for (i = 0; i < arr.Length; i++)
            {
                result[i] = ops(arr[i]);
            }

            return result ;
        }
        static void PrintArray(double[] arr)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]:#.##}" + ",");
            }
        }
        static void Main()
        {
            double[] arr = new double[] { 1, 2, 3, 4, 5 };
            double[] result;
            DoubleOps ops = PerformSqrt;

            result = ProcessArray(arr, ops);
            Console.Write("The array after performing square root :");
            PrintArray(result);
            Console.WriteLine();

            Console.Write("The array after performing square :");
            ops = PerformSquare;
            result = ProcessArray(arr, ops);
            PrintArray(result);
            Console.WriteLine();

        }
    }
}
