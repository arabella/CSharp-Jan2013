using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

class Hmwrk8_17
{
    static void Main()
    {
        Console.WriteLine("Enter a date and time in the format day.month.year hour:minute:second");
        string date = Console.ReadLine();
        
        DateTime input = DateTime.ParseExact(date, "d.MM.yyyy H:m:s", CultureInfo.InstalledUICulture);
        input = input.AddHours(6.5);

        Console.WriteLine("{0} {1}", input,input.ToString("dddd", new CultureInfo("bg-BG")));
    }
}
