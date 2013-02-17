using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to hexadecimal numbers (directly).

class Hmwrk4_6
{
    static void Main()
    {
        Console.WriteLine("Enter your binary number:");
        string binary = Console.ReadLine();
        string hexnumber = String.Empty;
        int left = binary.Length % 4;

        if (left != 0)
        {
            binary = binary.PadLeft(((binary.Length / 4) + 1)*4, '0');
        }

        for (int i = 0; i < binary.Length; i = i + 4)
        {
            string groupoffour = binary.Substring(i, 4);
            hexnumber = hexnumber + string.Format("{0:X}", Convert.ToByte(groupoffour, 2));
        }
        hexnumber.ToString();
        Console.WriteLine("The hexadecimal representation of your binary number is {0}", hexnumber);
    }
}