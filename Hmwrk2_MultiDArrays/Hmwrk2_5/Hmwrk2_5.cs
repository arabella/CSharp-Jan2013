using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given an array of strings.
// Write a method that sorts the array by the length of its elements (the number of characters composing them).

class Hmwrk2_5
  {
    static void Main()
     {
         string[] myString = new string[] { "aaaa", "bb", "cccc", "dd", "f", "yyyyyyyy", "h" };

         var sortedString =
             from str in myString
             orderby str.Length
             select str;

         Console.WriteLine("The sorted array of strings by length is:");
         foreach (var str in sortedString)
         {
             Console.WriteLine(str);
         }
     }
  }

