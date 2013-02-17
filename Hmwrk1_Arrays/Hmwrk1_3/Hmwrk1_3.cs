using System;
//Write a program that compares two char arrays lexicographically (letter by letter).

class Hmwrk1_3
{
    static void Main()
    {
        Console.WriteLine("Enter a few letters for the first char array - no spaces!");
        char[] firstCharArray = Console.ReadLine().ToCharArray();
        Console.WriteLine("Enter a few letters for the second char array - no spaces!");
        char[] secondCharArray = Console.ReadLine().ToCharArray();


        int length = firstCharArray.Length;

        if (firstCharArray.Length < secondCharArray.Length)
        {
            Console.WriteLine("First Char Array is first lexicographically");
        }

        else if (firstCharArray.Length > secondCharArray.Length)
        {
            Console.WriteLine("Second Char Array is first lexicographically");
        }

        else
        {
            for (int i = 0; i < length; i++)
            {
                //Checks each element of the first array against corresponding element of the second array until they are the same


                while (firstCharArray[i] == secondCharArray[i])
                {
                    Console.WriteLine(" {0} chars are the same", i + 1);
                    break;
                }
                if (firstCharArray[i] < secondCharArray[i])
                {
                    Console.WriteLine("First Char Array is first lexicographically");
                }
                if (firstCharArray[i] > secondCharArray[i])
                {
                    Console.WriteLine("Second Char Array is first lexicographically");

                }

            }
        }
    }
}

