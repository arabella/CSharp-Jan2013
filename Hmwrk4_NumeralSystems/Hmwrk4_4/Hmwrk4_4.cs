using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to their decimal representation.

class Hmwrk4_4
{
   static void Main()
   {
       Console.WriteLine("Enter you hexadecimal number:");
       string input = (Console.ReadLine());
       input = input.ToUpper();
       char[] number = input.ToCharArray();

       string[] hexadecimal = number.Select(str =>
           {
               switch (str)
               {
                   case 'A':
                       return "10";
                   case 'B':
                       return "11";
                   case 'C':
                       return "12";
                   case 'D':
                       return "13";
                   case 'E':
                       return "14";
                   case 'F':
                       return "15";
                   case '1':
                       return "1";
                   case '2':
                       return "2";
                   case '3':
                       return "3";
                   case '4':
                       return "4";
                   case '5':
                       return "5";
                   case '6':
                       return "6";
                   case '7':
                       return "7";
                   case '8':
                       return "8";
                   case '9':
                       return "9";
                   default: return "invalid";
               }
           }).ToArray();

    int[] result = hexadecimal.Select(x => int.Parse(x)).ToArray();
    Array.Reverse(result);
    int sum = 0;

    for (int i = 0; i < result.Length; i++)
    {
        sum = sum + result[i] * (int)Math.Pow(16, i);
    }
    Console.WriteLine("The decimal representation of your hexadecimal number is {0}", sum);
   }
}

