using System;
//Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

class Hmwrk1_12
{
    static void Main()
    {
        char[] alphabet = new char[26];
        int j = 65;
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = Convert.ToChar(j + i);
        }
        Console.WriteLine("Enter your word");
        string word = Console.ReadLine().ToUpper();
        char[] wordletters = word.ToCharArray();

        for (int i = 0; i < wordletters.Length; i++)
        {
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (wordletters[i] == alphabet[k])
                {
                    Console.Write(k + " ");
                }
            }
        }
    }
}

