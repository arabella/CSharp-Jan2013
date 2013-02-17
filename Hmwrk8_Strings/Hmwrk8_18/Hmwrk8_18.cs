using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class Hmwrk8_18
{
    static bool IsValidEmail(string str)
    {
        return Regex.IsMatch(str, @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}");
    }
    static void Main()
    {
        string text = @"Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string[] searchemails = text.Split(' ');
        foreach (var str in searchemails)
        {
            if (IsValidEmail(str))
            {
                Console.WriteLine(str);
            } 
        }
    }
}
