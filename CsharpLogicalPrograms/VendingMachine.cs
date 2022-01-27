using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class VendingMachine
    {
        public static int[] notesArray = new int[] { 2000, 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
        public static void GenerateAmount()
        {
            //Declaring and initializing local variable
            int amount, count = 0, notes = 0;

            Console.Write("Enter the amount to withdraw : ");
            amount = int.Parse(Console.ReadLine());
            int tempAmount = amount;
            for (int i = 0; i <= 9; i++)
            {
                count = tempAmount / notesArray[i];
                if (count != 0)
                {
                    Console.WriteLine("The count of Rs."+notesArray[i]+" notes is : "+count);
                }
                notes += count;
                tempAmount %= notesArray[i];
            }
            Console.WriteLine("The total number of notes is "+notes);
            Console.WriteLine("The total amount is " +amount);
            Console.ReadLine(); 
        }
    }
}
