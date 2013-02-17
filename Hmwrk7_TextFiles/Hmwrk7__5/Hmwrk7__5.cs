using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
//an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. 
class Hmwrk7_5
{
    static int FindBestSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int bestx = 0;
        int besty = 0;
        int tempSum;

        for (int x = 0; x < matrix.GetLength(0) - 1; x++)
        {
            for (int y = 0; y < matrix.GetLength(1) - 1; y++)
            {
                tempSum = matrix[x, y] + matrix[x, y + 1] + matrix[x + 1, y] + matrix[x + 1, y + 1];
                if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                    bestx = x;
                    besty = y;
                }
                
            } 
        }
        return bestSum;
    }
    static void Main()
    {
        string line = String.Empty;
        string element = String.Empty;
        using (StreamReader myMatrix = new StreamReader("matrix.txt", Encoding.GetEncoding("windows-1251")))
        {
            line = myMatrix.ReadLine();
            int n = int.Parse(line); //first line gives matrix size
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] elements = myMatrix.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                    matrix[i, j] = int.Parse(elements[j]);
            }
            using (StreamWriter writer = new StreamWriter("bestSum.txt", false, Encoding.GetEncoding("windows-1251")))
            {
                writer.Write(FindBestSum(matrix));
            }
             Console.WriteLine(FindBestSum(matrix));
        }
    }
}

