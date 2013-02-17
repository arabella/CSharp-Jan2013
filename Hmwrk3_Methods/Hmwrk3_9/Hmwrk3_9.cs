using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that return the maximal element in a portion of array of integers 
//starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.


class Hmwrk3_9
  {
   
    static int MaxElement(int[] array, int k, int temp, int biggestElem)
    {
        temp = int.MinValue;
        biggestElem = int.MinValue;

        for (int i = k; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                 temp = array[i]; 
            }
            else if (array[i] < array[i + 1])
	        {
                temp = array[i + 1];
	        }
            else  temp = array[i] = array[i + 1];
            if (biggestElem < temp)
            {
                biggestElem = temp;
            }
        } return biggestElem;
    }

    static int[] SortArrayAscending(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > array[i])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    
                } 
            }
        }

        return array;
    }

    static void Print(int[] array)
       {
           for (int i = 0; i < array.Length; i++)
           {
               Console.WriteLine(array[i]);
           }
       }
            
    static void Main()
    {
        int[] array = { 4, 8, 1, 14, 0, 28, -32, 2, 2 };
        
        Console.WriteLine("Enter a value for k that is smaller than {0}: ", array.Length - 1);
        int k = int.Parse(Console.ReadLine());
        int biggestElem = int.MinValue;
        int temp = int.MinValue;
        Console.WriteLine("The biggest element starting from index {0} is {1}", k, MaxElement(array, k, temp, biggestElem));

        Console.WriteLine("This is the array sorted ascending:");
        SortArrayAscending(array);
        Print(array);

        Array.Reverse(array);
        Console.WriteLine("This is the array sorted descending:");
        Print(array);
    }
  }

