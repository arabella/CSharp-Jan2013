using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

class Hmwrk8_11
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("{0,10:D}",number);
        Console.WriteLine();
        Console.Write("{0,10:X}", number);
        Console.WriteLine();
        Console.Write("{0,10:P}", number);
        Console.WriteLine();
        Console.Write("{0,10:E}", number);
        Console.WriteLine();
    }
}
