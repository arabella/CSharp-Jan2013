using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that sorts an array of strings using the quick sort algorithm

class Hmwrk14
{
    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        IComparable pivot = elements[left + (right - left) / 2];
        int i = left; int j = right;
        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                IComparable temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;
                i++;
                j--;
            }
        }
        if (left < j)
        {
            Quicksort(elements, left, j);
        }
        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
    static void Main()
    {
        string[] unsorted = { "bfgs", "jh", "nmnbggy", "jhghfdrts", "s", "hdh" };
        Quicksort(unsorted, 0, unsorted.Length - 1);
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.WriteLine(unsorted[i] + " ");
        }
    }
}