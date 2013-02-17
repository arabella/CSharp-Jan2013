using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

class Hmwrk3_10
{
    static void CalculateFactorial(int i)
    {
        BigInteger result = 1;

        for (int j = 1; j <= i; j++)
        {
            result = result * j;
        }
        Console.WriteLine("The factorial of your number is:  {0,5}",result);
        Console.WriteLine();
    }
    static void Main()
    {
       Console.WriteLine("Enter a number:");
       int i = int.Parse(Console.ReadLine());

       CalculateFactorial(i);
    }
}
