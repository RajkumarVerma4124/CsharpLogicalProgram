using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class SquareRoot
    {
        //Method to compute square root of a given number
        public static double ComputeSqRtNonNegNum(double c)
        {
            //Declaring variables
            double epsilon, t, sqRoot;

            while (true)
            {
                if (c < 0)
                {
                    Console.Write("Number should not be negative\n");
                    return 0;
                }
                else
                {
                    epsilon = 1.0e-15;
                    t = c;
                    while (Math.Abs(t-c/t) > epsilon*t)
                    {
                        t = (c/t+t)/2.0;
                    }
                    sqRoot = Math.Round(t , 2);
                    return sqRoot;
                }
            }
        }
    }
}
