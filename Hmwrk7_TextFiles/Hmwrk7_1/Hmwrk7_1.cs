using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
//Write a program that reads a text file and prints on the console its odd lines.

class Hmwrk7_1
{
    static void Main()
    {
        using (StreamReader myReader = new StreamReader("../../test.txt", Encoding.GetEncoding("Unicode")))
        {
            int lineNumber = 1;
            string line = myReader.ReadLine();
            while (line != null)
            {
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = myReader.ReadLine();
                lineNumber = lineNumber + 2;
            }
        }
    }
}
