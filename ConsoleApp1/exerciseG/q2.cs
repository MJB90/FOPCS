using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseG
{
    class q2
    {
        /*Method to print the array elements*/
        static void PrintArray(int[] arrayElements, int numOfElements)
        {
            int i;
            for (i = 0; i < numOfElements; i++)
            {
                Console.Write(arrayElements[i] + "  ");
            }
            Console.WriteLine();
        }

        /*Method to perform selection sort in descending order*/
        static void SelectionSort(int[] arrayElements, int numOfElements)
        {
            //Local variables
            int i, j, maxPos,maxElement, temp;

            /*
             After every pass find the largest number in the unsorted part
            and push the largest into the sorted part
             */
            for (i = 0; i < numOfElements; i++)
            {
                maxPos = i;
                maxElement = arrayElements[i];

                //Find the largest element from i+1 to numOfElements
                for (j = i + 1; j < numOfElements; j++)
                {
                    if (arrayElements[j] > maxElement)
                    {
                        maxElement = arrayElements[j];
                        maxPos = j;
                    }
                }

                //If the current position does not have the largest number then swap
                if(i != maxPos)
                {
                    temp = arrayElements[i];
                    arrayElements[i] = arrayElements[maxPos];
                    arrayElements[maxPos] = temp;
                }

                //Print the array elements after every pass
                Console.WriteLine("The array after pass {0} :", i + 1);
                PrintArray(arrayElements, numOfElements);
            }
        }
        static void Main()
        {
            //Local variables
            int i, numOfElements;
            int[] arrayElements;
            string[] elements;

            //Ask user to enter the number of elements
            Console.Write("Enter the number of elements : ");
            numOfElements = Convert.ToInt32(Console.ReadLine());

            //Instantiate the array of elements
            arrayElements = new int[numOfElements];

            //Ask user for the array elements separated by comma
            Console.Write("Enter the elements separated by comma : ");
            elements = Console.ReadLine().Split(',');

            for (i = 0; i < numOfElements; i++)
            {
                //Insert the elemets in the array after splitting the string of numbers
                arrayElements[i] = Convert.ToInt32(elements[i]);
            }

            //Perform selection sort
            SelectionSort(arrayElements,numOfElements);
        }
    }
}
