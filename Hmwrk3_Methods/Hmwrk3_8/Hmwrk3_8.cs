using System;
using System.Collections.Generic;
//Write a method that adds two positive integer numbers 
//represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
class Hmwrk3_8
{
    private static int[] Sum(int[] firstNumber, int[] secondNumber)
    {

        List<int> sum = new List<int>(Math.Max(firstNumber.Length, secondNumber.Length) + 1);
        int shorter = Math.Min(firstNumber.Length, secondNumber.Length);
        int carry = 0;
        for (int i = 0; i < shorter; i++)
        {
            sum.Add((firstNumber[i] + secondNumber[i] + carry) % 10);
            carry = ((firstNumber[i] + secondNumber[i] + carry) / 10) % 10;
        }
        if (firstNumber.Length > shorter)
        {
            for (int i = shorter; i < firstNumber.Length; i++)
            {
                sum.Add((firstNumber[i] + carry) % 10);
                carry = ((firstNumber[i] + carry) / 10) % 10;
            }
        }
        if (secondNumber.Length > shorter)
        {
            for (int i = shorter; i < secondNumber.Length; i++)
            {
                sum.Add((secondNumber[i] + carry) % 10);
                carry = ((secondNumber[i] + carry) / 10) % 10;
            }
        }
        if (carry == 1)
        {
            sum.Add(carry);
        }
        return sum.ToArray();
    }
    static void Main()
    {
        Console.Write("Enter the first positive integer: ");
        string first = Console.ReadLine();
        int[] firstNumber = new int[first.Length];
        int length = first.Length;
        for (int i = 0; i < length; i++)
        {
            firstNumber[i] = int.Parse(first[length - 1 - i].ToString());
        }
        Array.Reverse(firstNumber);
        Console.Write("Enter the second positive integer: ");
        string second = Console.ReadLine();
        int[] secondNumber = new int[second.Length];
        length = second.Length;
        for (int i = 0; i < length; i++)
        {
            secondNumber[i] = int.Parse(second[length - 1 - i].ToString());
        }
        Array.Reverse(secondNumber);
        int[] summedArray = Sum(firstNumber, secondNumber);
        Console.Write("The sum of your numbers equals: ");
        for (int i = summedArray.Length - 1; i >= 0; i--)
        {
            Console.Write(summedArray[i] + " ");
        }
        Console.WriteLine();
    }

   
}