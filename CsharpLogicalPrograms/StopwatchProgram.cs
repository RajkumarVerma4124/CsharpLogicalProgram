using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms
{
    public class StopwatchProgram
    {
        public static Stopwatch watch = new Stopwatch();
        public static void StartWatch()
        {
            int ch;
            do
            {
                Console.WriteLine("1. START\n2. STOP \n3. Elapsed \n4. EXIT");
                Console.Write("Enter Your Choice : ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        watch.Start();
                        break;
                    case 2:
                        watch.Stop();
                        break;
                    case 3:
                        double elapsedTime = watch.ElapsedMilliseconds/1000;
                        Console.WriteLine("Elapsed Time is : "+elapsedTime+ " Seconds");
                        Console.ReadLine(); 
                        break;

                }

            } while (ch < 3);
        }
    }
}
