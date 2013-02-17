using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found. 

class Hmwrk8_21
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. ";
        text = text.ToUpper();
        int[] alphabet = new int [(int)('z' + 1)];
        char symbol;
        foreach (var ch in text)
        {
           symbol = ch;
           alphabet[(int)symbol]++;
        }       
        for (int i = 65; i < 91; i++)
        {
            if (alphabet[i] != 0)
            {
                Console.WriteLine("{0} - {1}", (char)i, alphabet[i]);
            }            
        }
    }
}