using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class SwapBinary
    {
        //Method to Swap binary number
        public static void SwapBinNum()
        {
            //Initializing varibale and array
            int decimalNum, i = 0, j, newDecNum=0;
            string binStr = "";
            int[] binary = new int[8];

            //Genrating the binary num of given decimal
            Console.Write("Enter a decimal number : ");
            decimalNum = int.Parse(Console.ReadLine());
            while (decimalNum > 0)
            {
                int rem = decimalNum % 2;
                binary[i++] = rem;
                decimalNum /= 2;
            }

            //Accessing the value from right to left
            Console.Write("Decimal to binary number : ");
            for (j = binary.Length - 1; j >= 0; j--)
                Console.Write(binary[j]+" ");
            Console.ReadLine();
            Console.WriteLine();

            //Accessing the first and last four digits before swapping
            Console.Write("First 4 bits: ");
            for (j = binary.Length - 1; j >= 4; j--)
            {
                Console.Write(binary[j] + " ");
            }
            Console.WriteLine();
            Console.Write("Last 4 bits : ");
            for (j = binary.Length / 2 - 1; j >= 0; j--)
            {
                Console.Write(binary[j] + " ");
            }
            Console.WriteLine();

            //Converting the int array to string for swapping
            Console.Write("After swapping first 4 bits : ");
            for (j = binary.Length/2 - 1; j >= 0; j--)
            {
                Console.Write(binary[j]+" ");
                binStr += binary[j];
            }
            Console.WriteLine();
            Console.Write("After swapping last 4 bits : ");
            for (j = binary.Length - 1; j >= binary.Length/2; j--)
            {
                Console.Write(binary[j]+" ");
                binStr += binary[j];
            }
            Console.WriteLine("\nReverse Binary Number : "+binStr);
            Console.WriteLine();

            //Converting the string binary to int binary 
            int newBinary = Convert.ToInt32(binStr);
            //Declaring variable to use in power
            int n = 0;
            //Converting binary to decimal
            while (newBinary > 0)
            {
                int lastNum = newBinary % 10;
                newDecNum += Convert.ToInt32(lastNum * Math.Pow(2, n));
                newBinary/=10;
                n++;
            }
            Console.WriteLine("Conversion From Binary To Decimal : "+newDecNum);
            Console.ReadLine();
        }
    }
}
