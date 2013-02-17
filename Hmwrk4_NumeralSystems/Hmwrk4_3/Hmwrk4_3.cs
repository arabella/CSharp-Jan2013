using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.

class Hmwrk4_3
{
    static void Main()
    {
        Console.WriteLine("Enter your decimal number:");
        int number = int.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();

        while (number > 0)
        {
            result.Append(number % 16);
            number = number / 16;
        }

        result.Replace("15", "F");
        result.Replace("14", "E");
        result.Replace("13", "D");
        result.Replace("12", "C");
        result.Replace("11", "B");
        result.Replace("10", "A");

        string hexresult = result.ToString();

        char[] hex = hexresult.ToCharArray();
        Array.Reverse(hex);
        hexresult = new string(hex);

        Console.WriteLine("The hexadecimal representation of your number is {0}", hexresult);
    }
}
