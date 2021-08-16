using System;

namespace ConsoleApp1
{
    class quiz1
    {
        static void Main()
        {
            int n;
            Console.Write("Please enter the length in cm : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The length in inch is: {0:0.000}", n / 2.54);
        }
    }
}
