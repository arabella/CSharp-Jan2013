using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class Hmwrk8_24
{
    static void Main()
    {
        string text = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order";
        string[] words = text.ToLower().Split(' ');
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine("{0}", word);
        }
    }
}
