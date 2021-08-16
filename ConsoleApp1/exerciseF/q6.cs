using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exerciseF
{
    class q6
    {
        static bool CheckValidMatriculationNumber(string user_matric_number, char[] checkSums)
        {
            //Return false if the length is not 7
            if (user_matric_number.Length != 7) return false;

            //Local variables
            int i, numeric_check_sum = 0, multiplier = 6;
            string middle_digits ;

            //Convert the string to upper case
            user_matric_number = user_matric_number.ToUpper();

            //Check if the middle digits are indeed digits--user should not enter other letters other than digits
            bool is_mid_only_digits = int.TryParse(user_matric_number.Substring(1, 5), out int mid_number);

            //Check if the first char is A and the last character is among the valid check sums
            if (user_matric_number[0] != 'A' || checkSums.Contains(user_matric_number[6]) == false) return false;

            //Check if the user has entered only digits and there is no negative sign 
            else if (is_mid_only_digits == false || mid_number < 0) return false;

            //Calculate the check sum
            else
            {
                middle_digits = user_matric_number.Substring(1, 5);

                for (i = 0; i < middle_digits.Length; i++)
                {
                    numeric_check_sum += ( (middle_digits[i] - '0') * multiplier );
                    multiplier--;
                }

                numeric_check_sum = numeric_check_sum % 5;

                //If the user entered checksum matches the calculated check sum then return true
                if (user_matric_number[6] == checkSums[numeric_check_sum]) return true;
            }

            //if none of the above conditions are satisfied then return false
            return false;
        }
        static void Main()
        {
            //Local variables
            string user_matric_number;

            //Ask the user for the matriculation number
            Console.Write("Enter your matriculation number : ");
            user_matric_number = Console.ReadLine();

            //Store the valid list of check sums
            char[] checkSums = new char[] { 'O', 'P', 'Q', 'R', 'S' };

            //Output the validity of the matriculation number
            if (CheckValidMatriculationNumber(user_matric_number, checkSums))
            {
                Console.WriteLine($"{user_matric_number} is a valid matriculation number!");
            }
            else Console.WriteLine($"{user_matric_number} is not a valid matriculation number!");

        }
    }
}
