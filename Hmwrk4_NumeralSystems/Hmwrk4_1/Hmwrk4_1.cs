using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert decimal numbers to their binary representation.
 class Hmwrk4_1
{
   static void Main()
   {
       Console.WriteLine("Enter your decimal number:");
       int number = int.Parse(Console.ReadLine());
       string binary = "";

       while (number > 0)
       {
           binary = number % 2 + binary;
           number = number / 2;
       }
       Console.WriteLine("The binary representation of your number is {0}", binary);
   }
}

