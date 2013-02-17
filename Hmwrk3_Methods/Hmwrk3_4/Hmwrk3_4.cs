using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

class Hmwrk3_4
  {
    static int Counter(int[] myArr, int k)
    {
        int counter = 0;
        for (int i = 0; i < myArr.Length; i++)
        {
            if (myArr[i] == k)
            {
                counter++;  
            }
        }
        return counter;
 
    }
     static void Main()
      {
          Console.WriteLine("Enter a number n:");
          int n = int.Parse(Console.ReadLine());
          int[] myArr = new int[n];
         //generate elements for the array
          for (int i = 0; i < n; i++)
          {
              Console.WriteLine("Enter the {0} element of the array:", i + 1);
              myArr[i] = int.Parse(Console.ReadLine());
          }
         //print array
          for (int i = 0; i < n; i++)
          {
              Console.Write(myArr[i] + " ");
          }
          Console.WriteLine();
         //test the program for k = 2
          int k = 2;
          
          Console.WriteLine(Counter(myArr,k));
      }
  }

