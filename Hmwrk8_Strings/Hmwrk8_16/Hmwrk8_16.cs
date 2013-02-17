using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
class Hmwrk8_16
{
    static void Main()
    {
        string firstdate = "01.02.2013";
        string seconddate = "4.04.2013";
        DateTime first = DateTime.ParseExact(firstdate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime second = DateTime.ParseExact(seconddate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Between {0}.{1}.{2} and {3}.{4}.{5} there are exactly {6} days", first.Day, first.Month, first.Year, second.Day, second.Month, second.Year, (second.Date - first.Date).TotalDays);
    }
}
