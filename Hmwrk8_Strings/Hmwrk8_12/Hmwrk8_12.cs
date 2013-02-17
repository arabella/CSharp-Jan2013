using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

class Hmwrk8_12
{
    static void Main()
    {
        string protocol = "[protocol]";
        string server = "[server]";
        string resource = "[resource]";
        string urlAddress = "http://downloads.academy.telerik.com/svn/csharppart2/Lectures/1.%20Arrays/Arrays.pptx";
        StringBuilder url = new StringBuilder();
        url.Append(urlAddress);
        StringBuilder http = new StringBuilder();
        StringBuilder www = new StringBuilder();
        StringBuilder dir = new StringBuilder();
        int index;
        index = urlAddress.IndexOf(":");
        http.Append(urlAddress.Substring(0, index));
        Console.WriteLine("{0}" + " = " + "\"{1}\"", protocol, http);
        url.Remove(0, index + 3);
        urlAddress = url.ToString();
        index = urlAddress.IndexOf("/");
        www.Append(urlAddress.Substring(0, index));
        Console.WriteLine("{0}"  + " = " + "\"{1}\"", server, www);
        dir = url.Remove(0, index);
        Console.WriteLine("{0}" + " = " + "\"{1}\"", resource, dir);
    }
}
