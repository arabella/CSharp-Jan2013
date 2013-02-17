using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that prints to the console which day of the week is today. Use System.DateTime.

class Hmwrk5_3
{
    static void Main()
    {
        DayOfWeek today = DateTime.Today.DayOfWeek;
        Console.WriteLine("Today is {0}", today);
    }
}