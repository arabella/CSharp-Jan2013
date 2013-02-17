using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the console and replaces all series of consecutive identical letters 
//with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class Hmwrk8_23
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder result = new StringBuilder();
        result.Append(text);
        for (int i = 0; i < result.Length - 1; i ++)
        {

            if (result[i] == result[i + 1])
            {
                result.Remove(i, 1);
                i--;
            }
        }
        Console.WriteLine(result.ToString());
    }
}