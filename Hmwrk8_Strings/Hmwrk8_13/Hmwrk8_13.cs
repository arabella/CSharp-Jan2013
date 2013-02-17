using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class Hmwrk8_13
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        string[] reversed = input.Split(' ', ',', '!');
        Array.Reverse(reversed);
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < reversed.Length; i++)
        {
            if (i == 0)
            {
                result.Append(reversed[i]);
            }
            else if (i == 4)
            {
                result.Append(reversed[i] + ", ");
            }
            else if (i == reversed.Length - 1)
            {
                result.Append(reversed[i] + "!");
            }
            else
            {
                result.Append(reversed[i] + " ");
            }
        }
        Console.WriteLine(result);
    }
}
