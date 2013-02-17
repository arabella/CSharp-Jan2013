using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class Hmwrk8_4
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string find = "in";
        int index = 0;
        int count = 0;
        while (index != -1)
        {
           index = text.ToLower().IndexOf(find, index + 1);
           count++;
        }
        Console.WriteLine("The substring {0} is found exactly {1} times in the text", find, count);
    }
}