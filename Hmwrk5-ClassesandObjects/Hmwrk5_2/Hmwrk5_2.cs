using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class Hmwrk5_2
{
   static void Main()
   {
      Random randomValue = new Random();
      for (int i = 0; i <= 10; i++)
      {
          int randomNumber = randomValue.Next(100) + 100;
          Console.WriteLine(randomNumber + " ");
      }
   }
}
