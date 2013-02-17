using System;
using System.Linq;
using System.Collections.Generic;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
class Hmwrk1_20
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Variations(int[] array, int index)
    {
        if (index == array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Variations(array, index + 1);
            }
        }
    }

    static void Main()
    {
        int[] variations = new int[k];
        Variations(variations, 0);
    }
}