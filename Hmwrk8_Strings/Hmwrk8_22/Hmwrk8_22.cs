using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the console and lists all different words in the string 
//along with information how many times each word is found.

class Hmwrk8_22
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var wordCounts = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!wordCounts.ContainsKey(word))
            {
                wordCounts.Add(word, 1);
            }
            else
            {
                wordCounts[word]++;
            }
        }
        var list = wordCounts.Keys.ToList();
        list.Sort();
        foreach (var key in list)
        {
            Console.WriteLine("{0} - {1}", key, wordCounts[key]);
        }
    }
}