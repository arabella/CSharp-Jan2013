using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class Hmwrk8_3
{
    static bool CheckBrackets(string check)
    {
       bool correct = false;
       int count = 0;
       check.ToCharArray();
       for (int i = 0; i < check.Length; i++)
       {
           if (check[i] == '(')
           {
               count++;
           }
           if (check[i] == ')')
           {
               count--;
           }
       }
       if (count == 0)
       {
           correct = true; 
       }
       return correct;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter an expression with brackets to check:");
        string expression = Console.ReadLine();
        Console.WriteLine("Brackets in your expression are put correctly: {0}", CheckBrackets(expression));
    }
}
