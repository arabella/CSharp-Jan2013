using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class Hmwrk4_8
{
    static void Main()
    {
        Console.WriteLine("Enter your 16-bit signed integer number:");
        short number = short.Parse(Console.ReadLine());

        char[] binary = new char[16];
        short index = 0;
        short position = 15;
        while (index < 16)
        {
            if ((number & (1 << index)) != 0)
            {
                binary[position] = '1';
            }
            else binary[position] = '0';
            index++;
            position--;            
        }
            string result = new string(binary);
            Console.WriteLine("The binary representation of your 16-bit signed integer number is {0}", result);
     }
}
