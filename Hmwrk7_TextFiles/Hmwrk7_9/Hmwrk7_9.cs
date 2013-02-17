using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class Hmwrk7_9
{
    static void Main()
    {
        string line = String.Empty;
        List<string> text = new List<string>();
        try
        {
            using (StreamReader myReader = new StreamReader("../../deleteoddlines.txt", Encoding.GetEncoding("Unicode")))
            {

                int lineNumber = 1;
                while ((line = myReader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        text.Add(line);
                    }
                    lineNumber++;
                }
            }
            using (StreamWriter myWriter = new StreamWriter("../../deleteoddlines.txt", false, Encoding.GetEncoding("Unicode")))
            {
                foreach (var s in text)
                {
                    myWriter.WriteLine(s);
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