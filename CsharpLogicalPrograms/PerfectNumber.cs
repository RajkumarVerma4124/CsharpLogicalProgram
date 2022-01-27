using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class PerfectNumber
    {
        //Method to check perfect number
        public static void ChkPerfectNum(int perfNum)
        {
            int sumNum = 0;
            for (int i = 1; i < perfNum; i++)
            {
                if (perfNum % i == 0)
                {
                    sumNum += i;
                }
            }
            if (sumNum == perfNum)
                Console.WriteLine("It is perfect number\n");
            else
                Console.WriteLine("It is not a perfect number\n");
        }
    }
}
