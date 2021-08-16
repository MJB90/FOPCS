using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q5
    {
        static void SetArray(int[] arr, int value)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }

        static void Main()
        {
            int[] arr;
            int i, arrSize, value;

            Console.Write("Enter the size of the array :");
            arrSize = Convert.ToInt32(Console.ReadLine());

            arr = new int[arrSize];

            Console.Write("Enter value with which the array needs to be set :");
            value = Convert.ToInt32(Console.ReadLine());

            SetArray(arr, value);

            Console.Write("The array after setting the value :");

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine();

        }
    }
}
