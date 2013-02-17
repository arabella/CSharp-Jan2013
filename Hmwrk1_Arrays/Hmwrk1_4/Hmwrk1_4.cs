using System;
class Hmwrk1_4
{
    //Write a program that finds the maximal sequence of equal elements in an array.

    static void Main()
    {
        Console.WriteLine("Enter a value for n: ");
        int n = int.Parse(Console.ReadLine());

        int[] myArr = new int[n];
        int counter = 1;
        int maxSequence = 1;
        int firstPosition = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter {0} element of the array", i + 1);
            myArr[i] = int.Parse(Console.ReadLine());

        }
        for (int i = 1; i < n; i++)
        {

            if (myArr[i - 1] == myArr[i])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxSequence)
            {
                maxSequence = counter;
                firstPosition = i - maxSequence + 1;
            }
        }

        Console.WriteLine("The maximal sequence of equal elements is {0}", maxSequence);

        for (int i = 0; i < maxSequence; i++)
        {
            Console.WriteLine(myArr[firstPosition + i] + " ");
        }

    }
}

