using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q6
    {
        static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] newArray = new int[newSize];
            int i;
            for (i = 0; i < arr.Length && i < newSize; i++)
            {
                newArray[i] = arr[i];
            }
            return newArray;
        }

        static void ResizeArrayII(ref int[] arr, int newSize)
        {
            int[] newArray = new int[newSize];
            int i;
            for (i = 0; i < arr.Length && i < newSize; i++)
            {
                newArray[i] = arr[i];
            }
            arr= newArray;
        }

        static void Main()
        {
            int[] arr, newArr;
            int i, newSize;

            arr = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Enter the new size of array :");
            newSize = Convert.ToInt32(Console.ReadLine());


            //Passing by value and returning a new array
            newArr = ResizeArray(arr, newSize);

            Console.Write("The array after resizing by returning new array:");
            for (i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + ",");
            }
            Console.WriteLine();

            //Passing the array by reference and changing the existing array
            ResizeArrayII(ref arr, newSize);

            Console.Write("The array after resizing by changing existing array:");

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
