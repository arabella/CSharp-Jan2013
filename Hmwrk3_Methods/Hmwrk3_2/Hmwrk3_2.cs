using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class Hmwrk3_2
    {
    static int GetMax(int a, int b)
    {
        int biggest = a;
        if (a < b)
        {
            biggest = b;
        }
        return biggest;
    }
        static void Main()
        {
            Console.WriteLine("Enter the first of three integers:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second of three integers:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last of three integers:");
            int c = int.Parse(Console.ReadLine());

            int result = GetMax(a, b);
            result = GetMax(result, c);

            Console.WriteLine("The biggest of three is {0}",result);
        }
    }

