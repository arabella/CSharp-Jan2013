using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given a sequence of positive integer values written into a string, 
//separated by spaces. Write a function that reads these values from given string and calculates their sum.

class Hmwrk5_6
{
    static void Main()
    {
        Console.WriteLine("Enter your numbers on the next line separated by spaces:");
        Console.WriteLine();
        string numbers = Console.ReadLine();
        string[] withoutSpaces = numbers.Split(' ');
        int[] onlyNumbers = Array.ConvertAll<string, int>(withoutSpaces, int.Parse);
        int sum = 0;
        for (int i = 0; i < onlyNumbers.Length; i++)
        {
            sum += onlyNumbers[i];
        }
        Console.WriteLine("The sum of the numbers you entered is {0}", sum);
    }
}

