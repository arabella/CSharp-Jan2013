using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

class Hmwrk19
{
    static void Main()
    {
        string text = "I was born on 14.06.1980. My sister was born on 3.7.1984. In 5/1999 I graduated my high school.The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        string pattern = @"\b\d{1,2}.\d{1,2}.\d{4}\b";
        DateTime date;
        foreach (Match word in Regex.Matches(text, pattern))
            if (DateTime.TryParseExact(word.Value, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
    }
}