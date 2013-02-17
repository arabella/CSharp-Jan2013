using System;


class Hmwrk1_2
{
    static void Main()
    {
        /*Write a program that reads two arrays from the console and compares them element by element.*/
        Console.WriteLine("Please enter two positive integers x and y");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x != y)
        {
            Console.WriteLine("Arrays are not equal");
        }

        else
        {
            int[] firstArray = new int[x];
            int[] secondArray = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Please enter {0} element of firstArray", i + 1);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Please enter {0} element of secondArray", i + 1);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool equalElements = true;

            for (int i = 0; i < x; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equalElements = false;
                }
            }

            Console.WriteLine("Arays are equal: {0}", equalElements);

        }


    }
}