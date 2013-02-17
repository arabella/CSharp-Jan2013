using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a method that checks if the element at given position in given array of integers 
//is bigger than its two neighbors (when such exist).

class Hmwrk3_5
{
    static void CheckNeighbors(int[] array, int index)
    {
        if (index == 0)
        {
            if (array[index] > array[index + 1])
            {
                Console.WriteLine("The element is bigger that its right neighbor"); ;
            }
            else Console.WriteLine("The element is not bigger that its right neighbor");
        }

        else if (index == array.Length - 1)
        {
            if (array[index] > array[array.Length - 2])
            {
                Console.WriteLine("The element is bigger that its left neighbor");
            }
            else Console.WriteLine("The element is not bigger that its right neighbor");
        }

        else 
        {
            if (array[index] > array[index - 1])
            {
                Console.WriteLine("The element is bigger that its left neighbor");
            }
            else
            {
                Console.WriteLine("The element is not bigger that its left neighbor");
            }
            if (array[index] > array[index + 1])
            {
                Console.WriteLine("The element is bigger that its right neighbor");
            }
            else
            {
                Console.WriteLine("The element is not bigger that its right neighbor");
            }
        }
    }
    static void Main()
    {
        int[] array = {2,13,-9,0,5,12,6,900};
        Console.WriteLine("Enter a number between 0 and 7 for the index of the element you want to check:");
        int index = int.Parse(Console.ReadLine());
        CheckNeighbors(array, index);
    }
}


