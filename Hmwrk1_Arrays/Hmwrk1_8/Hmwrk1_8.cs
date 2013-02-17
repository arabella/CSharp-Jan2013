using System;
class Hmwrk_8
//Write a program that finds the sequence of maximal sum in given array. 
{
    static void Main()
    {
        int[] myArr = { 2, 3, -6, -1, 25, -1, 6, 4, -8, 18 };

        int maxSum = int.MinValue;
        int tempSum = 0;
        int j = 0;
        int start = 0;
        int end = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            if (tempSum > 0)
            {
                tempSum += myArr[i];
            }
            else
            {
                tempSum = myArr[i];
                j = i;
            }
            if (tempSum > maxSum)
            {
                maxSum = tempSum;
                end = i;
                start = j;
            }
        }
        Console.WriteLine("The maximal sum is {0}", maxSum);
        for (int i = start; i <= end; i++)
        {
            Console.Write(myArr[i] + " ");
        }
    }
}

