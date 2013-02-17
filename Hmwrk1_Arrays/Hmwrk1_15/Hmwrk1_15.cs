using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the Sieve Of Eratosthenes Algorithm
class Hmwrk1_15
{
    static void Main()
    {
        bool[] arr = new bool[10000000];

        for (int i = 2; i < Math.Sqrt(arr.Length); i++)
        {
            if (arr[i] == false)
            {
                for (int j = i * i; j < arr.Length; j += i)
                {
                    arr[j] = true;
                }
            }
        }
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] == false)
            {
                Console.Write(i + " ");
            }

        }
    }
}

