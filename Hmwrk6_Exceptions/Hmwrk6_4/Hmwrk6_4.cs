using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//Write a program that downloads a file from Internet and stores it the current directory. 
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

class Hmwrk6_4
{
    static void Main()
    {
        Console.WriteLine("Enter the url of the file you need to download:");
        string url = Console.ReadLine();
        string fileName = Path.GetFileName(url);
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile(url, fileName);
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("You haven't entered the path to the file.");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The address you've entered is invalid or the file doesn't exist");
            }
        }
    }
}
