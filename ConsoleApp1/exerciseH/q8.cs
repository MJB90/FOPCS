using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q8
    {
        static void PrintArray(int[,] arr)
        {
            int i, j;

            for (i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] MultiplyMatrix(int[,] a, int[,] b)
        {
            int[,] c = new int[a.GetLength(0), b.GetLength(1)];
            int i, j, k;

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < b.GetLength(1); j++)
                {
                    for (k = 0; k < a.GetLength(1); k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }

        static void Main()
        {
            int r1, c1, r2, c2, i , j;
            int[,] a, b, c;
            string[] elements;

            Console.Write("Enter the number of rows & cols for matrix 1 separated by comma : ");
            elements = Console.ReadLine().Split(',');
            r1 = Convert.ToInt32(elements[0]);
            c1 = Convert.ToInt32(elements[1]);

            Console.Write("Enter the number of rows & cols for matrix 2 separated by comma : ");
            elements = Console.ReadLine().Split(',');
            r2 = Convert.ToInt32(elements[0]);
            c2 = Convert.ToInt32(elements[1]);

            if (c1 != r2)
            {
                Console.WriteLine("The matrices cannot be multiplied ");
                return;
            }

            a = new int[r1, c1];
            b = new int[r2, c2];

            Console.WriteLine("--------- Enter data for matrix 1 --------------");
            for (i = 0; i < r1; i++)
            {
                Console.Write("Enter data for row {0} separated by comma : " ,i + 1 );
                elements = Console.ReadLine().Split(',');
                for (j = 0; j < c1; j++)
                {
                    a[i, j] = Convert.ToInt32(elements[j]);
                }
            }

            Console.WriteLine("--------- Enter data for matrix 2 --------------");
            for (i = 0; i < r2; i++)
            {
                Console.Write("Enter data for row {0} separated by comma : ", i + 1);
                elements = Console.ReadLine().Split(',');
                for (j = 0; j < c2; j++)
                {
                    b[i, j] = Convert.ToInt32(elements[j]);
                }
            }

            c = MultiplyMatrix(a, b);
           
            Console.WriteLine("\nMatrix 1");
            PrintArray(a);
            Console.WriteLine("\nMatrix 2");
            PrintArray(b);
            Console.WriteLine("\nResult Matrix");
            PrintArray(c);
            Console.WriteLine();
        }

    }
}
