using System;

namespace ConsoleApp1
{
    class quiz2
    {
        static void Main()
        {
            //Local variables
            int number_of_items;
            double amount_to_pay,total_amount;

            //Prompting user to enter the number of items purchased
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Number of items to purchase :");
            number_of_items = Convert.ToInt32(Console.ReadLine());

            //Calculate total amount purchased
            total_amount = number_of_items * 500;

            //Calculate the amount to be paid after certain discounts
            if (total_amount > 2000 && total_amount <= 3000)
            {
                amount_to_pay = total_amount - 0.03 * total_amount;
            }
            else if(total_amount > 3000 && total_amount <= 6000)
            {
                amount_to_pay = total_amount - 0.05 * total_amount;
            }
            else if(total_amount > 6000)
            {
                amount_to_pay = total_amount - 0.08 * total_amount;
            }
            else
            {
                amount_to_pay = total_amount;
            }

            //Output the amount to be paid to the shop
            Console.WriteLine($"Please pay ${amount_to_pay:0.00}");

        }
    }
}
