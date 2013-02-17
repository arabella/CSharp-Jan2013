﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method that returns the last digit of given integer as an English word.
// Examples: 512  "two", 1024  "four", 12309  "nine".

class Hmwrk3_3
    {
    static string DigitToWord(string number)
    {
        switch (number)
        {
            case "0": Console.WriteLine("zero"); break;
            case "1": Console.WriteLine("one"); break;
            case "2": Console.WriteLine("two"); break;
            case "3": Console.WriteLine("three"); break;
            case "4": Console.WriteLine("four"); break;
            case "5": Console.WriteLine("five"); break;
            case "6": Console.WriteLine("six"); break;
            case "7": Console.WriteLine("seven"); break;
            case "8": Console.WriteLine("eight"); break;
            case "9": Console.WriteLine("nine"); break;
        }
        return number;
    }
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int i = int.Parse(Console.ReadLine());

                int remainder = Math.Abs (i % 10);
                string number = Convert.ToString(remainder);
                DigitToWord(number);
        }
    }

