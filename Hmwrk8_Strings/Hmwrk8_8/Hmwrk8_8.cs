using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Write a program that extracts from a given text all sentences containing given word.

class Hmwrk8_8
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] sentences = text.Split('.');
        string pattern = "in";
        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.Matches(sentences[i], "\\b" + pattern + "\\b",RegexOptions.IgnoreCase).Count > 0)
                Console.WriteLine(sentences[i] + ".");
        }
    }
}