using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to binary numbers (directly).
class Hmwrk4_5
{
    static void Main()
    {
        Console.WriteLine("Enter your hexadecimal number:");
        string hexnumber = Console.ReadLine();
        hexnumber.ToUpper();
        string binarynumber = String.Join(String.Empty, hexnumber.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        Console.WriteLine("The binary representation of your hexadecimal number is {0}", binarynumber);
    }
}