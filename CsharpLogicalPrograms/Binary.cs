using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class Binary
    {
        //Method to convert decimal to binary number
        public static void ToBinary()
        {
            //Initializing varibale and array
            int decimalNum, i = 0, j;
            int[] binary = new int[8];

            Console.Write("Enter a decimal number : ");
            decimalNum = int.Parse(Console.ReadLine());
            //using quotient and remaider to get 0 and 1
            while (decimalNum > 0)
            {
                int rem = decimalNum % 2;
                binary[i++] = rem;
                decimalNum /= 2;
            }
         
            //Accessing the value from left to right
            Console.Write("Binary number : ");
            for (j = binary.Length-1; j >= 0; j--)
                Console.Write(binary[j] + " ");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
