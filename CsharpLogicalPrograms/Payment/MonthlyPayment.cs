using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms.Payments
{
    public class MonthlyPayment
    {
        //Method to compute monthly payment
        public static void ComputeMonthlyPayment()
        {
            //Declaring Variables
            double principle, year, interest, numberOfMonths, monthlyInterestRate, payment, monthlyPayment;

            Console.Write("Enter a principal amount : ");
            principle = double.Parse(Console.ReadLine());

            Console.Write("Enter how many year you would take to complete principal amount : ");
            year = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest : ");
            interest = double.Parse(Console.ReadLine());

            numberOfMonths = 12 * year;    //no. of months
            monthlyInterestRate = interest / (12 * 100);    //monthly interest rate

            //Formula to calculate monthly payemnt with interest to complete principal amount
            payment = (principle * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfMonths));
            monthlyPayment = Math.Round(payment, 2);

            Console.WriteLine("Monthly payment with interest is : "+monthlyPayment+" .Rs");
            Console.ReadLine();

        }
    }
}
