using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
//Write a program that extracts from given XML file all the text without the tags. 
class Hmwrk1_10
{
    static void Main()
    {
        string line;
        using (StreamReader myReader = new StreamReader("xmltags.txt", Encoding.GetEncoding("Unicode")))
        {
            while ((line = myReader.ReadLine()) != null)
            {
                Regex edit = new Regex("<[^>]*>");
                line = edit.Replace(line, "");
                Console.WriteLine(line);
            }
        }      
    }
}