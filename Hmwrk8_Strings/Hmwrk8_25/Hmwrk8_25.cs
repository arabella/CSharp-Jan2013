using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
class Hmwrk8_25
{
    static void Main()
    {
        using (StreamReader read = new StreamReader("text.html"))
        {
            string text;
            while ((text = read.ReadLine()) != null)
            {
                Console.Write(Regex.Replace(text, "<.*?>", " "));
                Console.WriteLine();
            }
        }
    }
}