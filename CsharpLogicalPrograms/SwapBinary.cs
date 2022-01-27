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
                Console.Write(binary[j] + " ");
            Console.ReadLine();
            Console.WriteLine();

            //Accessing the first and last four digits
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

            //Converting the int array to string
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
            Console.WriteLine();

            //Initializing new int and char array to store rev binary
            char[] ch = new char[binStr.Length];
            ch = binStr.ToCharArray();
            int[] arr = new int[binStr.Length];

            //Conversion from string to char to int array
            Console.Write("Integer Value After Swapping : ");
            for (i = 0; i < ch.Length; i++)
            {
                ch[i] = binStr.ElementAt(i);
                arr[i] = (int)Char.GetNumericValue(ch[i]);
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();

            //Getting the new number by converting binary to decimal
            int count = 0;
            for (i = ch.Length-1; i >= 0 ; i--)
            {
                if (arr[i] == 1)
                {
                    newDecNum += Convert.ToInt32(Math.Pow(2, count));
                    count++;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine("Conversion From Binary To Decimal : "+newDecNum);
            Console.ReadLine();
        }
    }
}
