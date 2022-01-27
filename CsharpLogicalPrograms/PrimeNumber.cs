using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class PrimeNumber
    {
        //Check Prime Number
        public static void ChkPrime(int pNum)
        {
            int count = 0;
            if (pNum == 1)
            {
                Console.WriteLine("Not a prime number");
            }
            else if (pNum == 2)
            {
                Console.WriteLine("It is a prime number");

            }
            else
            {
                for (int i = 2; i <= pNum; i++)
                {
                    if (pNum % i == 0)
                        count++;
                }
                if (count == 1)
                    Console.WriteLine("Prime Number");
                else
                    Console.WriteLine("Not a Prime Number");
            }

            Console.ReadLine();
        }
    }
}
