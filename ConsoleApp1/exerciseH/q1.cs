using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseH
{
    class q1
    {
        static int ReadInteger(string message)
        {
            int parsedInt;
            while (true)
            {
                Console.Write(message);
                if (Int32.TryParse(Console.ReadLine(), out parsedInt))
                {
                    return parsedInt;
                }
            }
        }
        static void Main()
        {
            int returnInteger;
            string message = "Please enter a interger : ";

            returnInteger = ReadInteger(message);
            Console.WriteLine("The valid integer entered by the user is :" + returnInteger);
            
        }
    }
}
