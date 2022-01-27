using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class Coupon
    {
        private static Random random = new Random();

        //Method to generate a coupon number
        public static int getCoupon(int lengthStart, int lengthEnd)
        {
            return random.Next(lengthStart, lengthEnd+1);
        }

        //Method to generate unique coupon number
        public static void Generate()
        {
            //Declaring and initializing value
            int lengthStart, lengthEnd, couponCount, count = 0;

            Console.Write("Enter the length start range for coupon number : "); 
            lengthStart = int.Parse(Console.ReadLine());
            Console.Write("Enter the length end range for coupon number : ");
            lengthEnd = int.Parse(Console.ReadLine());
         
            Console.Write("Enter how many distinct coupon number you want : ");
            couponCount = int.Parse(Console.ReadLine());
               
            //HashSet is used to get unique coupon number
            HashSet<int> coupon = new HashSet<int>();
            while (coupon.Count < couponCount)
            {
                int randomNumber = getCoupon(lengthStart,lengthEnd);
                coupon.Add(randomNumber);
                count++;
            }

            //Displaying unique coupon number
            foreach(int distinctCoupon in coupon)
            {
                Console.WriteLine("Distinct coupon number is : "+distinctCoupon);
            }
            Console.WriteLine("Count to get distinct coupon number : "+count);
            Console.ReadLine();

        }
    }
}
