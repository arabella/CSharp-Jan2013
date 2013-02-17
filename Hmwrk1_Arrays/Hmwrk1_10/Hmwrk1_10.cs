using System;
class Hmwrk1_10
{
    //Write a program that finds in given array of integers a sequence of given sum S (if present). 
    static void Main()
    {
        int[] myArr = { 4, 3, 1, 4, 2, 5, 8 };
        int givenSum = 11;
        int start = 0;
        int currentSum = 0;

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            currentSum = currentSum + myArr[i];
            start = i;

            for (int j = i + 1; j < myArr.Length; j++)
            {
                currentSum = currentSum + myArr[j];

                if (currentSum == givenSum)
                {
                    for (int k = start; k <= j; k++)
                        Console.Write(myArr[k] + " ");
                    Console.WriteLine();
                    return;
                }
            }

            currentSum = 0;
        }

        Console.WriteLine("There is no such sum in the array");
    }
}