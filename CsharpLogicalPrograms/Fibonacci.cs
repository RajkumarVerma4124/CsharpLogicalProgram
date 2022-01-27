using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class Fibonacci
    {
        //Displaying Fibonacci Series upto nth term
        public static void ComputeFiboSeries(int limit)
        {
            if (limit > 0)
            {
                int fNum = 0, sNum = 1, tNum;
                //display starting two numbers of series
                Console.Write("Fibonacci Series : " + fNum + "  " + sNum + "  ");
                while (sNum <= limit)
                {
                    tNum = fNum + sNum;
                    fNum = sNum;
                    sNum = tNum;
                    if (sNum <= limit)
                        Console.Write(tNum + " ");
                }

            }
            else
                Console.WriteLine("Wrong input");
            Console.ReadLine();
        }

    }
}
