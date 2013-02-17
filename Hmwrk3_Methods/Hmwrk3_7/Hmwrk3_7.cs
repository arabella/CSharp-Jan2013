using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256  652

class Hmwrk3_7
  {
    static void ReversedNumber(char[] reversed)
    {

        Array.Reverse(reversed);
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.Write(reversed[i]);
        }
        Console.WriteLine();

        
    }
    static void Main()
    {
        Console.WriteLine("Enter the number you want to reverse:");
        string number = Console.ReadLine();
        char[] reversed = number.ToCharArray();
        ReversedNumber(reversed);
    }
  }

