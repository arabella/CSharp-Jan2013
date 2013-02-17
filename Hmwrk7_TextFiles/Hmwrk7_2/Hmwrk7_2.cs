using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Write a program that concatenates two text files into another text file.

class Hmwrk7_2
{
    static void Main()
    {
        string first = String.Empty;
        string second = String.Empty;
        using (StreamReader firstText = new StreamReader("../../firsttext.txt"))
        {
            first = firstText.ReadToEnd(); 
        }
        using (StreamReader secondText = new StreamReader("../../secondtext.txt"))
        {
            second = secondText.ReadToEnd();
        }
        string concatenated = first + second;
        StreamWriter concatenatedText = new StreamWriter("../../conctext.txt");
        using (concatenatedText)
        {
            concatenatedText.Write(concatenated);
        }
        Console.WriteLine("The files have been concatenated in conctext.txt");
    }
}