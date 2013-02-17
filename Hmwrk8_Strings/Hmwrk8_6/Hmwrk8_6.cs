using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

class Hmwrk8_6
{
    static void Main()
    {
        Console.WriteLine("enter something shorter than 20 characters");
        string input = Console.ReadLine();
        if (input.Length > 20)
        {
            Console.WriteLine("Your input must be less than 20 characters. Try again: ");
            input = Console.ReadLine();
        }
        StringBuilder characters20 = new StringBuilder();
        characters20.Append(input);
        
        if (characters20.Length < 20)
        {
            for (int i = characters20.Length; i <= 20; i++)
            {
                characters20.Append('*');
            }
        }       
        Console.WriteLine(characters20);
    }
}