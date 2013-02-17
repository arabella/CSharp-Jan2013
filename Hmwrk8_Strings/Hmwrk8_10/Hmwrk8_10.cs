using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
class Hmwrk8_10
{
    static void Main()
    {
        //string input = Console.ReadLine();
        string input = "Hi!";
        foreach (var c in input)
        {
            Console.Write(@"\u{0:x4}", (short)c);
        }
        Console.WriteLine();
    }
}