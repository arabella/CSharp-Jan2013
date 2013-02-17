using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
//operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

class Hmwrk8_7
{
    static void Main()
    {
        Console.WriteLine("Enter the text to encode");
        char[] input = Console.ReadLine().ToCharArray();
        Console.WriteLine("Enter the cipher");
        char[] cipher = Console.ReadLine().ToCharArray();
        StringBuilder longkey = new StringBuilder();
        for (int i = 0; i < (input.Length / cipher.Length) + (input.Length % cipher.Length); i++)
        {
            for (int j = 0; j  < cipher.Length; j++)
            {
                longkey.Append(cipher[j]);
            }
        }

        StringBuilder encoded = new StringBuilder();
        for (int i = 0; i < longkey.Length; i++)
        {
            encoded.Append((char)(input[i] ^ longkey[i]));
        }
        Console.WriteLine(encoded);

        StringBuilder decoded = new StringBuilder();
        for (int i = 0; i < longkey.Length; i++)
        {
            decoded.Append((char)(encoded[i] ^ longkey[i]));
        }
        Console.WriteLine(decoded);
    }
}