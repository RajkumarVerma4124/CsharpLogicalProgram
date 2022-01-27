using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms.DaysOfWeeks
{
    public class DaysOfWeek
    {
        //Method to compute week day
        public static void ComputeWeekDay()
        {
            //Declaring variables
            int month, day, year;

            while (true)
            {
                //condition for month
                Console.Write("Enter a month number like january for 1 and so forth : ");
                month = int.Parse(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Months should be between 1 and 12");
                    continue;

                }

                //Condition for date
                Console.Write("Enter a day number : ");
                day = int.Parse(Console.ReadLine());
                if ( month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day < 1 || day > 31)
                    {
                        Console.WriteLine("Days should be between 1 and 31");
                        continue;
                    }
                        
                }
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day < 1 || day > 30)
                    {
                        Console.WriteLine("Days should be between 1 and 30");
                        continue;
                    }
                        
                }
                if (month == 2 )
                {
                    if (day < 1 || day > 29)
                    {
                        Console.WriteLine("Days should be between 1 and 29");
                        continue;
                    }
                        
                }

                //Condition for a year
                Console.Write("Enter a Year : ");
                year = int.Parse(Console.ReadLine());
                if (year < 1000 || year > 10000)
                {
                    Console.WriteLine("Years should be between 1000 and 10000");
                    continue;
                }

                // Using the Gregorian calendar formula
                int y0 = year - (14 - month) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = month + 12 * ((14 - month) / 12) - 2;
                int d0 = (day + x + 31 * m0 / 12) % 7;
                int date = d0;

                //Checking the week day
                if (date == 0)
                {
                    Console.WriteLine("The Day Is : Sunday");
                    break;
                }
                if (date == 1)
                {
                    Console.WriteLine("The Day Is : Monday");
                    Console.ReadLine();
                    break;
                }
                if (date == 2)
                {
                    Console.WriteLine("The Day Is : Tuesday");
                    Console.ReadLine();
                    break;
                }
                if (date == 3)
                {
                    Console.WriteLine("The Day Is : Wednesday");
                    Console.ReadLine();
                    break;
                }
                if (date == 4)
                {
                    Console.WriteLine("The Day Is : Thursday");
                    Console.ReadLine();
                    break;
                }
                if (date == 5)
                {
                    Console.WriteLine("The Day Is : Friday");
                    Console.ReadLine();
                    break;
                }
                if (date == 6)
                {
                    Console.WriteLine("The Day Is : Saturday");
                    Console.ReadLine();
                    break;
                }

            }

        }
    }
}
