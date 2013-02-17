using System;
//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 

class Hmwrk1_11
{
    static void Main()
    {
        int[] sortedArray = { 2, 4, 6, 7, 9, 12, 14, 16, 19, 46, 58, 78, 90 };
        int target = 0; ;
        sortedArray[target] = 90;
        int start = 0;
        int end = sortedArray.Length;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (sortedArray[mid] < sortedArray[target])
            {
                start = mid;

            }
            if (sortedArray[mid] > sortedArray[target])
            {
                end = mid;
            }
            if (sortedArray[mid] == sortedArray[target])
            {
                Console.WriteLine("The index of target number is {0}", mid);
                break;
            }
        }
    }
}

