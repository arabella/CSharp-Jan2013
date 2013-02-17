using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.

class Hmwrk6_1
{

    static void Main()
    {
        Console.WriteLine("Enter your number:");
         try
         {
             int number = int.Parse(Console.ReadLine());
             if (number < 0)
             {
                 throw new ArithmeticException();
             }
             Console.WriteLine("The square root of your number is {0}", (int)Math.Sqrt(number));
         }
         catch (ArithmeticException)
         {
             Console.Error.WriteLine("Your input is negative or too big");
         }
         catch (FormatException)
         {
             Console.Error.WriteLine("Your input is not a valid number");
         }
         finally
         {
             Console.WriteLine("Good bye!");
         }
     }
}
