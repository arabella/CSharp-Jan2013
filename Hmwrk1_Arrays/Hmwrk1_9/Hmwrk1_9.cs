using System;

//Write a program that finds the most frequent number in an array.

class Hmwrk1_9
{
    static void Main()
    {
        int[] myArr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int counter = 1;
        int mostFrequent = 0;
        for (int i = 0; i < myArr.Length - 1; i++)
        {
            int tempCounter = 1;
            for (int j = 1; j < myArr.Length; j++)
            {
                if (myArr[i] == myArr[j])
                {
                    tempCounter++;
                }
            }
            if (tempCounter > counter)
            {
                counter = tempCounter;
                mostFrequent = myArr[i];
            }
        }
        Console.WriteLine("The most frequent number is {0}", mostFrequent);
        Console.WriteLine("It's found {0} times in the array", counter);
    }

}