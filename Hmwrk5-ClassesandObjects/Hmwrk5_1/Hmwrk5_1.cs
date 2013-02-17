using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class Hmwrk5_1
{
   static void Main()
   {
       Console.WriteLine("Enter the year to check: ");
       ushort year = ushort.Parse(Console.ReadLine());

       Console.WriteLine("Is {0} leap: {1} ",year, DateTime.IsLeapYear(year));
   }
}