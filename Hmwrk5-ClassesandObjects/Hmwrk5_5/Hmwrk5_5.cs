using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that calculates the number of workdays between today and given date, 
//passed as parameter. Consider that workdays are all days from Monday to Friday 
//except a fixed list of public holidays specified preliminary as array.

class Hmwrk5_5
{
    static int CalcBusinessDays(DateTime initialDay, DateTime futureDay)
    {
        List<DateTime> officialHolidays = new List<DateTime>()
        {
                new DateTime(2013, 03, 03),
                new DateTime(2013, 05, 01),
                new DateTime(2013, 05, 06),
                new DateTime(2013, 05, 24),
                new DateTime(2013, 12, 24),
                new DateTime(2013, 12, 25),
                new DateTime(2013, 12, 26),
                new DateTime(2013, 12, 31),
        };
        int businessDays = 0;
        while (futureDay > initialDay)
        {
            if (!((initialDay.DayOfWeek == DayOfWeek.Saturday) || (initialDay.DayOfWeek == DayOfWeek.Sunday) || officialHolidays.Contains(initialDay)))
            {
                businessDays++;
            }
            initialDay = initialDay.AddDays(1);
        }
        return businessDays;
    }
    static void Main()
    {
        Console.WriteLine("Enter the date:");
        DateTime futureDay = DateTime.Parse(Console.ReadLine());
        DateTime initialDay = DateTime.Today;

        if (futureDay < initialDay)
        {
            DateTime swap = futureDay;
            futureDay = initialDay;
            initialDay = swap;
        }
      
        Console.WriteLine("Between {0} and {1} there are exactly {2} business days", initialDay, futureDay, CalcBusinessDays(initialDay, futureDay));
    }  
}
    

    

