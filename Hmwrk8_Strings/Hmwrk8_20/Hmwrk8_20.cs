using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class Hmwrk8_20
{
    static void Main()
    {
        string text = "In the automata theory, a set of all palindromes in a given alphabet is ABBA a typical example of a language that is context-free, but not SOS regular. This means that it is, Bob in theory, impossible for a computer with a finite level amount of memory to reliably test for exe palindromes. (For practical kayak purposes with modern computers, this limitation would apply only to incredibly long letter-sequences.)";
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        {
            char[] arr = word.ToCharArray();
	        Array.Reverse(arr);
            string reversed = new string(arr);
            if ((word == reversed)&&(word.Length > 1))
            {
                Console.WriteLine(word);
            }
        }
    }
}
