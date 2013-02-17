using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

class Hmwrk4_7
{
   static void Main()
   {
       Console.WriteLine("Enter your number:");
       string number = Console.ReadLine();
       Console.WriteLine("Enter the base of your number:");
       int s = int.Parse(Console.ReadLine());
       Console.WriteLine("Enter the base you want to convert your number to:");
       int d = int.Parse(Console.ReadLine());
       string result = String.Empty;

       int decimalResult = 0;

       for (int i = 0; i < number.Length; i++)
       {
           if (number[i] >= 'a')
            {
                decimalResult += (number[i] - 'a' + 10) * (int)Math.Pow(s, (number.Length - 1 - i));
            }
            else
            {
                decimalResult += (number[i] - '0') * (int)Math.Pow(s, (number.Length - 1 - i));
            }
       }

       while (decimalResult > 0)
       {
           int digit = decimalResult % d;
           if (digit <= 9)
           {
               result = result + digit;
           }
           else result = result + (char)('a' + digit - 10);
           decimalResult = decimalResult / d;
       }
           char[] arr = result.ToCharArray();
           Array.Reverse(arr);
           string final = new string(arr);

           Console.WriteLine("Your converted number is: {0}", final);
       
   }
}

