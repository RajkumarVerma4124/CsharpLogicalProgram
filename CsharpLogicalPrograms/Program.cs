using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpLogicalPrograms.Payments;
using CsharpLogicalPrograms.TempratureConversion;
using CsharpLogicalPrograms.DaysOfWeeks;

namespace CsharpLogicalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\n1: Fibonacci series"+
                            "\n2: Perfect number program"+
                            "\n3: Prime number program"+
                            "\n4: Reverse a number or string" +
                            "\n5: Generate unique coupon number"+
                            "\n6: Stopwatch program"+
                            "\n7: Vending machine program"+
                            "\n8: DaysOfweek program"+
                            "\n9: Temperature conversion program"+
                            "\n10: Monthly payment program"+
                            "\n11: Square root program"+
                            "\n12: Binary conversion"+
                            "\n13: Swap binary number program"+
                            "\n14: Exit"
                             );
                Console.Write("Enter a choice from above : ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter a limit of the fibonacci series : ");
                        int fibNum = int.Parse(Console.ReadLine());
                        Fibonacci.ComputeFiboSeries(fibNum);
                        break;
                    case 2:
                        Console.Write("Enter a number to check if its perfect number : ");
                        int perfNum = int.Parse(Console.ReadLine());
                        PerfectNumber.ChkPerfectNum(perfNum);
                        break;
                    case 3:
                        Console.Write("Enter a number to check prime : ");
                        int chkNum = int.Parse(Console.ReadLine());
                        PrimeNumber.ChkPrime(chkNum);
                        break;
                    case 4:
                        Console.Write("Enter a number or string to reverse : ");
                        string numRev = Console.ReadLine();
                        ReverseNumber.ComputeReverseNum(numRev);
                        break;
                    case 5:
                        Coupon.Generate();
                        break;
                    case 6:
                        StopwatchProgram.StartWatch();
                        break;
                    case 7:
                        VendingMachine.GenerateAmount();
                        break;
                    case 8:
                        DaysOfWeek.ComputeWeekDay();
                        break;
                    case 9:
                        Temperature.Conversion();
                        break;
                    case 10:
                        MonthlyPayment.ComputeMonthlyPayment();
                        break;
                    case 11:
                        Console.Write("Enter a non negative number : ");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("The square root of " + c + " is : "+SquareRoot.ComputeSqRtNonNegNum(c)); ;
                        break;
                    case 12:
                        Binary.ToBinary();
                        break;
                    case 13:
                        SwapBinary.SwapBinNum();
                        break;
                    default:
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}
