using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseD
{
    class q3
    {
        static void Main()
        {
            //Local variables
            int pc_guess, user_guess, number_of_guess = 0;

            //Get a new instance of random class to generate random numbers
            Random rd = new Random();

            //Get the pc guess using the random object
            pc_guess = rd.Next(0, 10);

            while (true)
            {
                //Ask the user for a number
                Console.Write("Guess a number : ");
                user_guess = Convert.ToInt32(Console.ReadLine());

                //increment the number of guesses
                number_of_guess++;

                //Check if the user guess is equal to pc guess
                if(user_guess == pc_guess)
                {
                    if (number_of_guess <= 2)
                    {
                        Console.WriteLine("You are a Wizard!");
                    }
                    else if(number_of_guess >2 && number_of_guess <= 5)
                    {
                        Console.WriteLine("You are a good guess!");
                    }
                    else
                    {
                        Console.WriteLine("You are lousy!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
    }
}
