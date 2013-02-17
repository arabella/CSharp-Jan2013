using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

class Hmwrk7_7
{
    static void Main()
    {
        using (StreamReader start = new StreamReader("bigfilestart.txt", Encoding.GetEncoding("Unicode")))
        {
            string line;
            List<string> text = new List<string>();
            while ((line = start.ReadLine()) != null)
            {
                text.Add(line);
            }
            text = text.Select(x => x.Replace("start", "finish")).ToList();

            using (StreamWriter edit = new StreamWriter("edit.txt", false, Encoding.GetEncoding("Unicode")))
            {
                foreach (var s in text)
                {
                    edit.WriteLine(s);
                } 
            }
        }
    }
}
