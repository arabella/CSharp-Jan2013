using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method ReadNumber(int start, int end) that enters an integer number 
//in given range [start…end]. If an invalid number or non-number text is entered, 
//the method should throw an exception. Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class Hmwrk6_2
{
    static int ReadNumber(int start, int end)
    {
            Console.WriteLine("Enter your number n:");
            int n = int.Parse(Console.ReadLine());
            if ((n < start) || (n > end))
            {
                throw new ArgumentOutOfRangeException();
            }
            return n;
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        try
        {
            Console.WriteLine("Enter 10 numbers between 1 and 100 so that every number is bigger than previous.");
            for (int i = 0; i < 10; i++)
            {
              int n = ReadNumber(start, end);
              start = n;
            }           
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.Error.WriteLine("Every number should be bigger than the last one you've entered and smaller than 100.");
        }
        finally
        {
            Console.WriteLine("Thank you");
        }
    }
}
