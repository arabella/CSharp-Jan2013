using System;

//Write a program that allocates array of 20 integers 
// and initializes each element by its index multiplied by 5. Print the obtained array on the console.

class Hmwrk1_1
{
    static void Main()
    {

        int[] myArr = new int[20];

        for (int i = 0; i < 20; i++)
        {
            myArr[i] = i * 5;
            Console.WriteLine(myArr[i]);
        }
    }
}
