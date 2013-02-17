using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

class Hmwrk7_3
{
    static void Main()
    {
        using (StreamReader myReader = new StreamReader("../../input.txt"))
        {
            using (StreamWriter insertLineNumbers = new StreamWriter("../../result.txt", false))
            {
                int lineNumber = 1;
                string line = myReader.ReadLine();
                while (line != null)
                {
                    insertLineNumbers.Write("{0}. {1}", lineNumber, line);
                    insertLineNumbers.WriteLine();
                    lineNumber++;
                    line = myReader.ReadLine();
                }
            }
        }
    }
}
