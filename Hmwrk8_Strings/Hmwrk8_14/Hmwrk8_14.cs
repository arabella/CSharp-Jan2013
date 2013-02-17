using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. 

class Hmwrk8_14
{
    static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {".NET", " – platform for applications from Microsoft"},
            {"CLR", " – managed execution environment for .NET"},
            {"namespace", " - hierarchical organization of classes"},
            {"string", " - represents a string of Unicode characters"},
            {"base", " - used to access members of the base class from within a derived class"},
            {"C#", " - multi-paradigm programming language"},
            {"Java", " - an island of Indonesia"},
        };
            Console.WriteLine("Enter a word to look up:");
            Console.WriteLine("Possible words: .NET, CLR, namespace, string, base, C#, Java");
            string search = Console.ReadLine();
            if (dictionary.ContainsKey(search))
            {
                Console.Write("{0}{1}", search, dictionary[search]);
            }
            else
            {
                Console.WriteLine("No such word in our dictionary. Go Google it with Bing!");
            }
            Console.WriteLine();
    }
}