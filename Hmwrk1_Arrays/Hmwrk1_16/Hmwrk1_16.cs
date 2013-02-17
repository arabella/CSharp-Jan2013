using System;
using System.Collections.Generic;
using System.Linq;
//We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S. 

class Hmwrk1_16
{
    static void Main()
    {
        int[] myArr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int tempSum = 0;
        int bestSum = 10;
        List<int> elements = new List<int>();
        string result = "no such subset";

        Array.Sort(myArr);
        for (int i = 0; i < myArr.Length; i++)
        {
            elements.RemoveRange(0, elements.Count);
            tempSum = myArr[i];
            elements.Add(myArr[i]);
            for (int q = 1; q < myArr.Length; q++)
            {
                if (tempSum < bestSum)
                {
                    tempSum = myArr[i] + myArr[q];
                }

                if (tempSum > bestSum)
                {
                    tempSum = tempSum - myArr[q];
                    elements.Remove(myArr[q]);
                    continue;
                }

                if (tempSum == bestSum)
                {
                    elements.Add(myArr[q]);
                    i = myArr.Length - 1;
                    result = "yes";
                    break;
                }

            }
        }
        Console.WriteLine(result);
        foreach (var e in elements)
        {
            Console.Write(e + " ");
        }
        Console.WriteLine();
    }
}





