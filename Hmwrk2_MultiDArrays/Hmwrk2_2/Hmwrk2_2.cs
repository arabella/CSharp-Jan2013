using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.

class Hmwrk2_1
{
    static void Main()
    {
        Console.WriteLine("Please enter a number N > 3:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number M > 3:");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int [n, m];
//read the matrix from the console input
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("Enter a value for cell [{0}] [{1}] in the matrix: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            } 
        }
//print the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0, 3}", matrix[i, j]);  
            }
            Console.WriteLine();
        }
//find best platform 3x3
        int bestSum = int.MinValue;
        int bestx = 0;
        int besty = 0;
        int tempSum;

        for (int x = 0; x < n - 2; x++)
        {
            for (int  y = 0; y  < m - 2; y++)
            {
                tempSum = matrix[x, y] + matrix[x, y+1] + matrix[x, y+2] +
                    matrix[x+1, y] + matrix[x+1, y+1] + matrix[x+1, y+2] +
                    matrix[x+2, y] +matrix[x+2, y+1] + matrix[x+2, y+2];

                if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                    bestx = x;
                    besty = y;
                }
            }
            tempSum = int.MinValue;
        }
        Console.WriteLine("The biggest sum is {0}", bestSum);
        Console.WriteLine("The platform is:");

        for (int x = bestx; x <= bestx + 2; x++)
        {
            for (int y = besty; y <= besty + 2; y++)
			{
			 Console.Write("{0,3}", matrix[x,y]);
			}
            Console.WriteLine();
        }
    }
}
