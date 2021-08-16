using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseG
{
    class q1
    {
        static string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        static void OutputSalesData(double[] salesData, int numOfElements)
        {
            double maxSales = salesData[0], minSales = salesData[0], totalSales = 0, averageSales;
            int i, maxSalesMonth = 0, minSalesMonth = 0;

            //Print the mothly sales data
            for (i = 0; i < numOfElements; i++)
            {
                Console.Write(months[i] + "\t");
            }
            Console.WriteLine();
            for (i = 0; i < numOfElements; i++)
            {
                Console.Write(salesData[i] + "\t");
            }
            Console.WriteLine();

            //Calcualte the min, max & average
            for (i = 0; i < numOfElements; i++)
            {
                if (salesData[i] < minSales)
                {
                    minSales = salesData[i];
                    minSalesMonth = i;
                }

                if (salesData[i] > maxSales)
                {
                    maxSales = salesData[i];
                    maxSalesMonth = i;
                }

                totalSales += salesData[i];
            }

            //Calculate the average sales
            averageSales = totalSales / 12;

            //Print the sales data
            Console.WriteLine("Max Sales month is " + months[maxSalesMonth]);
            Console.WriteLine("Min Sales month is " + months[minSalesMonth]);
            Console.WriteLine("The total sales is {0:0.00}" , totalSales);
            Console.WriteLine("The average sales is {0:0.0000}" , averageSales);
        }
        static void Main()
        {
            //Local variables
            int i, numOfElements;
            double[] salesData;
            string[] elements;

            //num of elements is 12 (months)
            numOfElements = 12;

            //Instantiate the array of elements
            salesData = new double[12];

            //Ask user for the array elements separated by comma
            Console.Write("Enter the sales of months separated by comma : ");
            elements = Console.ReadLine().Split(',');

            for (i = 0; i < numOfElements; i++)
            {
                //Insert the elemets in the array after splitting the string of numbers
                salesData[i] = Convert.ToDouble(elements[i]);
            }

            //Calculate & output sales data
            OutputSalesData(salesData, numOfElements);
        }
    }
}
