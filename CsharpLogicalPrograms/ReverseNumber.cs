using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class ReverseNumber
    {
        //Printing Reverse of a number and string
        public static void ComputeReverseNum(string numR)
        {
            // Converting string to character array
            char[] charNum = numR.ToCharArray();
            // Declaring an empty string
            string tempStr = string.Empty;
            for (int i = charNum.Length - 1; i > -1; i--)
            {
                // Append each character to the temp string.
                tempStr += charNum[i];
            }
            Console.WriteLine(tempStr);
            Console.ReadLine();
        }
    }
}
