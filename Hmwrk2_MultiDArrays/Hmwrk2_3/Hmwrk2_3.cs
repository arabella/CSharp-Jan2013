using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix. 
class Hmwrk2_3
{
   static void Main()
   {
       int n = 3;
       int m = 4;
       string[,] strArray = new string [n, m];
       strArray[0, 0] = "ha";
       strArray[0, 1] = "fifi";
       strArray[0, 2] = "ho";
       strArray[0, 3] = "hi";
       strArray[1, 0] = "fo";
       strArray[1, 1] = "ha";
       strArray[0, 2] = "hi";
       strArray[0, 3] = "fifi";
       strArray[2, 0] = "xxx";
       strArray[2, 1] = "hi";
       strArray[2, 2] = "ha";
       strArray[2, 3] = "ha";

       int tempSeq = 1;
       int bestSeq = 1;
       int tempx = 0;
       int tempy = 0;
       List<string> maxSeqElements = new List<string>();

       for (int x = 0; x < n; x++)
       {
           for (int y = 0; y < m - 1; y++)
           {
               if (strArray[x, y] == strArray[x, y + 1])
               {
                   tempSeq++;
               }
               else tempSeq = 1;
               if (tempSeq == bestSeq)
               {
                 maxSeqElements.Add(strArray[x, y]);   
               }
               
               if (tempSeq > bestSeq)
               {
                   bestSeq = tempSeq;
                   maxSeqElements.Clear();
                   maxSeqElements.Add(strArray[x, y]);
               }
               tempSeq = 1;
           }
       }

       for (int y = 0; y < m; y++)
       {
           for (int x = 0; x < n - 1; x++)
           {
               if (strArray[x, y] == strArray[x + 1, y])
               {
                   tempSeq++;
               }
               else tempSeq = 1;
               if (tempSeq == bestSeq)
               {
                   maxSeqElements.Add(strArray[x, y]);
               }
               if (tempSeq > bestSeq)
               {
                   bestSeq = tempSeq;
                   maxSeqElements.Clear();
                   maxSeqElements.Add(strArray[x, y]);
               }
               tempSeq = 1;
           }
       }

       for (int i = 0; i < m - 1; i++)
       {
           for (int x = 0, y = tempy; x < n - 1 && y < m - 1; x++, y++)
           {
               if (strArray[x, y] == strArray[x + 1, y + 1])
               {
                   tempSeq++;
               }
               else tempSeq = 1;
               if (tempSeq == bestSeq)
               {
                   maxSeqElements.Add(strArray[x, y]);
               }
               if (tempSeq > bestSeq)
               {
                   bestSeq = tempSeq;
                   maxSeqElements.Clear();
                   maxSeqElements.Add(strArray[x, y]);
               }
               tempy++;
           }
       }

       for (int i = 0; i < n - 1; i++)
       {
           for (int x = tempx, y = 0; x < n - 1 && y < m - 1; x++, y++)
           {
               if (strArray[x, y] == strArray[x + 1, y + 1])
               {
                   tempSeq++;
               }
               else tempSeq = 1;
               if (tempSeq == bestSeq)
               {
                   maxSeqElements.Add(strArray[x, y]);
               }
               if (tempSeq > bestSeq)
               {
                   bestSeq = tempSeq;
                   maxSeqElements.Clear();
                   maxSeqElements.Add(strArray[x, y]);
               }
               tempx++;
           }
       }

       Console.WriteLine(bestSeq);
       for (int i = 0; i < maxSeqElements.Count; i++)
       {
           Console.Write(maxSeqElements[i] + " ");
       }
   }
}

