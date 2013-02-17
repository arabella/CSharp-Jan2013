using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
class Hmwrk7_6
{
    static void Main()
    {
        using (StreamReader nameList = new StreamReader("../../unsorted.txt", Encoding.GetEncoding("Unicode")))
        {
            List<string> unsorted = new List<string>();
            string line;
            while ((line = nameList.ReadLine()) != null)
            {
                unsorted.Add(line);
            }
            unsorted.Sort();
            using (StreamWriter sortednames = new StreamWriter("../../sorted.txt", false, Encoding.GetEncoding("Unicode")))
            {
                foreach (var s in unsorted)
                {
                    sortednames.WriteLine(s);
                } 
            }
            Console.WriteLine("Check sorted.txt in /Debug");
        }     
    }
}

