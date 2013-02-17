using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
// Write a program to test this method.

class Hmwrk3_1
    {

    static void PrintName()
    {
        Console.WriteLine("Please enter you name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}", name);
    }
        static void Main()
        {
            PrintName();
        }
    }

