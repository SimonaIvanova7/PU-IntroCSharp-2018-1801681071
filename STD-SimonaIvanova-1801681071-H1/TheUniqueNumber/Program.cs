using System;

namespace TheUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last 4 digits of your faculty number here:");
            int last4Digits = int.Parse(Console.ReadLine());

            double uniqueNumberDouble = MyUniqueNumber(AgeAfter10Years(age), last4Digits);
            string uniqueNumberFormatted = string.Format("{0:0.####}", uniqueNumberDouble);
           Console.WriteLine("After 10 years you will be " + AgeAfter10Years(age) + " years old. " +
                 "And your unique number is: " + uniqueNumberFormatted + ".");
                    }
        static int AgeAfter10Years(int currentAge)
        {
            int ageAfter10Years = currentAge + 10;
            return ageAfter10Years;
        }
        static double MyUniqueNumber(int ageAfter10Years, int last4DigitsOfFacNumber)

        {
            double myUniqueNumber =
            (ageAfter10Years
            * last4DigitsOfFacNumber) / Math.PI;
            return myUniqueNumber;
        }
       
    }





}
