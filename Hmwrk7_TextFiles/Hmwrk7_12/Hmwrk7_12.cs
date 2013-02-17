using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
//Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

class Hmwrk7_12
{
    static void Main()
    {
        try
        {
            List<string> wordslist = new List<string>();
            using (StreamReader myReader = new StreamReader("../../wordslist.txt", Encoding.GetEncoding("Unicode")))
            {
                string line = String.Empty;
                while ((line = myReader.ReadLine()) != null)
                {
                    wordslist.Add(line);
                }
            }
            using (StreamReader editor = new StreamReader("../../full.txt", Encoding.GetEncoding("Unicode")))
            {
                string line = String.Empty;
                while ((line = editor.ReadLine()) != null)
                {
                    foreach (var word in wordslist)
                    {
                        line = line.Replace(word, String.Empty);
                    }
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("We couldn't find your file. Please check the path you specified.");
        }
        catch (PathTooLongException)
        {
            Console.Error.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine("You don't have permition to edit this file.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("The sourceFileName and destinationFileName parameters specify the same file.");
        }
    }
}
