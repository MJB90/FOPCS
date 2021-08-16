using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class quiz3
    {
        const int atm_pin = 123456;
        static void Main()
        {
            //Local variables
            int pin, number_of_tries = 0;

            Console.Write("Welcome to Bank of ISS\n");
            while (true)
            {
                //Ask the user for the PIN
                Console.Write("Enter your PIN: ");
                pin = Convert.ToInt32(Console.ReadLine());
                //Increment the number of tries
                number_of_tries++;

                //Account can be accessed if the pin is correct
                if(pin == atm_pin)
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    break;
                }
                //Let the user try again if the number of tries are less than 3
                else if(number_of_tries < 3)
                {
                    Console.WriteLine("Incorrect PIN. Please try again.");
                }
                //Lock the account once the number of tries are 3 or more
                else if(number_of_tries >= 3)
                {
                    Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                    return;
                }
            }
            
            //Execute code when the pin is correct
        }
    }
}
