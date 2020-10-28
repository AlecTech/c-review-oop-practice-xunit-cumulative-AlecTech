using System;
using System.Linq;
using Xunit;


namespace XUnitCumulativePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 
             * ●	Create a method in XUnitCumulativePractice.Program.cs called ValidateOneToOneHundredEven() that will accept a string(“1” or “20” etc.) as a parameter.
                 o Validate that the string:
                     ▪	Is an integer(numeric, will safely parse to int).
                     ▪	Is between 1 and 100.
                     ▪	Is even.
                 o If it is, return true.Otherwise return false
             * 
             */

            Console.WriteLine("Enter num from 1 - 100");

             string x = Console.ReadLine();

            bool y = ValidateOneToOneHundredEven(x);
            Console.WriteLine($"your input is int, between 1-100 and even {y}");

        }

        public static bool ValidateOneToOneHundredEven(string str)
        {
            //int input = Int32.Parse(str);
            //string numString = "1287543"; //"1287543.0" will return false for a long
            long number1 = 0;
            bool canConvert = long.TryParse(str, out number1);
            if (canConvert == true)               
            {
                if (number1 > 0 && number1 <= 100)
                {
                    if (number1 % 2 == 0)
                    {
                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
