using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.


//My program returns the indexes of all elements that are bigger than their neighbors
//and -1 if they are not.

class Hmwrk3_6
 {

    static int CheckNeighbors(int[] array, int index)
    {
        if (index == 0)
        {
            if (array[index] > array[index + 1])
            {
                return index;
            }
            else return -1;
        }
        else if (index == array.Length - 1)
        {
            if (array[index] > array[index - 1])
            {
                return index;
            }
            else return -1;
        }
        else
        {
            if((array[index] > array[index - 1])&&(array[index] > array[index - 1]))
            {
                return index;
            }
            else return -1;
        }
    }
    static void Main(string[] args)
    {
        int[] array = {9,23,43,7,65,-9,87,0,12,456789};
        

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(CheckNeighbors(array, i));
        }

       
    }
 }
