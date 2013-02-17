using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks.
class Hmwrk8_9
{
    static void Main(string[] args)
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbidden = "PHP, CLR, Microsoft";
        StringBuilder input = new StringBuilder();
        input.Append(text);
        string[] words = forbidden.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            input.Replace(words[i], new string('*', words[i].Length));
        }
        input.ToString();
        Console.WriteLine(input);
    }
}
