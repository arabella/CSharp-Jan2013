using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.


class Hmwrk7_11
{
    static void Main()
    {
        using (StreamReader myReader = new StreamReader("../../test.txt", Encoding.GetEncoding("Unicode")))
        {
            string line = String.Empty;
            while ((line = myReader.ReadLine()) != null)
            {
                string pattern = "\\btest\\w*";
                string edit = String.Empty;
                line = Regex.Replace(line, pattern, edit);
            }
        }
    }
}