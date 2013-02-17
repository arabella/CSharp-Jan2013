using System;
class Hmwrk1_6
{
    //Write a program thet reads 2 integers from the console N and K and an array of N elements.
    //Find in the Array those K elements that have maximal sum.
    static void Main()
    {
        Console.WriteLine("Enter an integer n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer k:");
        int k = int.Parse(Console.ReadLine());

        int maxSum = 0;
        int[] myArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a value for the {0} element of the array", i + 1);
            myArr[i] = int.Parse(Console.ReadLine());
        }


        Array.Sort(myArr);

        for (int i = n - k; i < myArr.Length; i++)
        {

            maxSum += myArr[i];
        }

        Console.WriteLine("The maximal sum of your {0} elements is {1}", k, maxSum);
    }
}
