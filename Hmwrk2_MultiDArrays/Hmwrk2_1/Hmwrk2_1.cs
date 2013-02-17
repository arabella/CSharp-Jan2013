using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
class Hmwrk2_1
{
 static void PrintMatrix(int n, int[,] matrix)
     {
         for ( int x = 0; x < n; x++)
         {
            for (int y = 0; y < n; y++)
            {
                Console.Write("{0,4}", matrix[x,y]); 
            }
            Console.WriteLine();            
        }
    }

     static void Main(string[] args)
    {
        Console.WriteLine("Enter a number for n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int counter = 1;
//matrix A
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                matrix[y, x] = counter++; 
            }
        }
        PrintMatrix( n, matrix );
        Console.WriteLine();
 //matrix B  
        counter = 1;
        for (int x = 0; x < n; x++)
        {
            if (x % 2 == 0)
            {
                for (int y = 0; y < n; y++)
                {
                    matrix[y, x] = counter++;
                }
            }
            else
            {
                for (int y = n - 1; y >= 0; y--)
                {
                    matrix[y, x] = counter++;
                }        
            }           
        }
        PrintMatrix(n, matrix);
        Console.WriteLine();
//matrix C
        counter = 1;
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y <= x; y++)
            {
                matrix[n - 1 + y - x, y] = counter++; 
            }
        }
        for (int x = n - 2; x >= 0; x--)
        {
            for (int y = x; y >= 0; y--)
            {
                matrix[x - y, n - y - 1] = counter++;
            } 
        }
        PrintMatrix(n, matrix);
        Console.WriteLine();
       
    }
}

