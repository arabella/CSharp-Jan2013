using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.IO;
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

class Hmwrk6_3
{
    static void Main()
    {
        Console.WriteLine("Enter the full path to your file:");
        string path = Console.ReadLine();
        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentException)
        {
            Console.Error.WriteLine("Your path contains only white space or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.Error.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("The path you entered is invalid, no such directory found.");
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("The file wasn't found in the specified directory");
        }
        catch (SecurityException)
        {
            Console.Error.WriteLine("Access denied");
        }        
    }
}

