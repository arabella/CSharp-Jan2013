using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that reads a list of words from a file words.txt and finds 
//how many times each of the words is contained in another file test.txt. 
//The result should be written in the file result.txt and the words should be sorted 
//by the number of their occurrences in descending order. Handle all possible exceptions in your methods.


class Hmwrk7_13
{
    static void Main()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        try
        {
            using (StreamReader myReader = new StreamReader("words.txt", Encoding.GetEncoding("Unicode")))
            {
                for (string word; (word = myReader.ReadLine()) != null; )
                {
                    dictionary.Add(word, 0);
                }
            }

            using (StreamReader myReader = new StreamReader("test.txt", Encoding.GetEncoding("Unicode")))
            {
                for (string line; (line = myReader.ReadLine()) != null; )
                {
                    string[] testContent = Regex.Split(line, @"\W+").ToArray<string>();
                    foreach (string item in testContent)
                    {
                        int Value = int.MinValue;

                        if (dictionary.TryGetValue(item, out Value))
                        {
                            dictionary[item] = Value + 1;
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("result.txt", false, Encoding.GetEncoding("Unicode")))
            {
                var Items = from pair in dictionary orderby pair.Value descending select pair;
                foreach (KeyValuePair<string, int> pair in Items)
                {
                    Console.WriteLine("{0} - {1}", pair.Value, pair.Key);
                    writer.WriteLine(pair.Value + " - " + pair.Key);
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
        catch (RegexMatchTimeoutException)
        {
            Console.Error.WriteLine("An error occured during word count!");
        }
    }
}
