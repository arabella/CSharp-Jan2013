using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//Write a program that compares two text files line by line and prints the number of lines
//that are the same and the number of lines that are different. Assume the files have equal number of lines.

class Hmwrk7_4
{
    static void Main()
    {
        int counterEqual = 0;
        int counterDiff = 0;

        StreamReader firstText = new StreamReader("../../first.txt", Encoding.GetEncoding("Unicode"));
        StreamReader secondText = new StreamReader("../../second.txt", Encoding.GetEncoding("Unicode"));
        string firstLine = firstText.ReadLine();
        string secondLine = secondText.ReadLine();
        using (firstText)
        {
            using (secondText)
            {
                while (secondLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        counterEqual++;
                    }
                    else
                    {
                        counterDiff++;
                    }
                    firstLine = firstText.ReadLine();
                    secondLine = secondText.ReadLine();
                }
            } 
        }
        Console.WriteLine("These two texts have {0} lines that are equal and {1} lines that are different.", counterEqual, counterDiff);
    }
}
