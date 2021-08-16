using System;

namespace ConsoleApp1
{
    class Program
    {
        static void BubbleSort(int[] a, int n)
        {
            for(int i =0; i < n - 1; i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n,i;

            //Get the size of the array
            Console.WriteLine("Enter the size of the array :");
            n = Convert.ToInt32(Console.ReadLine());

            //Get the array elements to be sorted 
            for(i = 0; i < n; i++)
            {
                Console.Write("Enter element {0} :", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Perform bubble sort
            BubbleSort(a, n);

            //Print the elements
            Console.WriteLine("The sorted elemets are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
