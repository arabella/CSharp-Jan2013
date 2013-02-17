using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to their decimal representation.
class Hmwrk4_2
{
  static void Main()
  {
      Console.WriteLine("Enter your binary number:");
      string dec = Console.ReadLine();
      int result = 0;

      for (int i = 0; i < dec.Length; i++)
      {
          if (dec[i] == '1')
          {
              result = result + (int)Math.Pow(2, dec.Length - i - 1);
          }
          
      }
      Console.WriteLine("The decimal representation of your binary number is {0}", result);
  }
}

