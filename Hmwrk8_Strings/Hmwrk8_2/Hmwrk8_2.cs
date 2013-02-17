using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

class Hmwrk8_2
{
    static void ReverseString(string str)
    {
     char[] reversed = str.ToCharArray();
     Array.Reverse(reversed);
     string result = new string(reversed);
     Console.WriteLine(result);
    }
    static void Main()
    {
        string str = "sample";
        ReverseString(str);
        Console.WriteLine();
    }
}