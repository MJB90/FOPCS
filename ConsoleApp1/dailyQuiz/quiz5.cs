using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class quiz5
    {
        //these arrays is visible in all the static method, 
        //so you can use them in your method implementation

        static int[] minIncomeArray = new int[]
            { 20000, 30000, 40000, 80000,
              120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
            { 0.02, 0.035, 0.07, 0.115,
              0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
            { 0, 200, 550, 3350,
              7950, 13950, 20750, 42350 };
        
        //Method to ask for Income
        static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income : ");
            return Convert.ToInt32(Console.ReadLine()); 
        }

        //Method to get tax bracket
        static int GetTaxBracket(int annualIncome)
        {
            //Local variables
            int i, taxBracket = -1;
            
            //Calcualte the largest index in array which value is less than annual income
            for (i = minIncomeArray.Length - 1; i >= 0; i--)
            {
                if (minIncomeArray[i] < annualIncome)
                {
                    taxBracket = i;
                    break;
                }
            }         
            return taxBracket;
        }

        //Method to calculate income tax
        static double CalculateIncomeTax(int annualIncome,int taxBracket)
        {
            return ((annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket]) + basePayableAmountArray[taxBracket];
        }

        //Method to print income tax
        static void PrintResult(int annualIncome, double taxPayable)
        {
            CultureInfo sg = new CultureInfo("en-SG");
            Console.WriteLine("For taxable income of ${0:0.00}, the tax payable amount is ${1:0.00}", annualIncome.ToString("N",sg), taxPayable.ToString("N", sg)) ;
        }
        static void Main(string[] args)
        {
            //Ask for the annual income
            int annualIncome = AskForIncome();

            //Get the tax Bracket
            int taxBracket = GetTaxBracket(annualIncome);

            //if there is no tax bracket, tax payable is 0
            if (taxBracket == -1)
            {
                PrintResult(annualIncome, 0);
            }
            else
            {
                //Calculate the tax payable
                double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
                PrintResult(annualIncome, taxPayable);
            }
        }

    }
}
