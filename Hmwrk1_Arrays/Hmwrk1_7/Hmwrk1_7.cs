using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
// move it at the second position, etc.

class Hmwrk1_7
{
    static void Main()
    {
        int[] arrSort = { 5, 1, 9, 3, 3, 2, 17, 13, 0, 100, -20 };
        int minElement;
        int swap;

        for (int i = 0; i < arrSort.Length; i++)
        {
            minElement = i;

            for (int second = i + 1; second < arrSort.Length; second++)
            {
                if (arrSort[second] < arrSort[minElement])
                {
                    minElement = second;
                }
            }

            swap = arrSort[i];
            arrSort[i] = arrSort[minElement];
            arrSort[minElement] = swap;

            Console.Write(arrSort[i] + " ");

        }

    }
}

