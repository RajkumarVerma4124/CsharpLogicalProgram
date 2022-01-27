using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogicalPrograms.TempratureConversion
{
    public class Temperature
    {
        public static double choice,temperature, fahr, fahrenite, celci;
        public static void Conversion()
        {
            do
            {
                Console.WriteLine("Choose the following conversion");
                Console.WriteLine("1.Temperature to Fahrenite\n2.Fahrenite to Temperature");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the temprature in celcius");
                        temperature = double.Parse(Console.ReadLine());
                        fahr = (temperature * 9 / 5) + 32;
                        Console.WriteLine("Celsius to Fahrenheit : "+fahr+" F");
                        break;

                    case 2:
                        Console.WriteLine("Enter the temprature in farhenite");
                        fahrenite = double.Parse(Console.ReadLine());
                        celci = (fahrenite - 32) * 5 / 9;
                        Console.WriteLine("Fahrenheit to Celsius : "+celci+" C");
                        break;
                    case 3:
                        break;
                }
            } while (choice <= 3);
        }
    }
}
