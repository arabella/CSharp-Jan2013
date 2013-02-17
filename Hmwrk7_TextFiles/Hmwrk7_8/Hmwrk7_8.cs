using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
//Modify the solution of the previous problem to replace only whole words (not substrings).

class Hmwrk7_8
{
    static void Main()
    {
        using (StreamReader text = new StreamReader("../../text.txt", Encoding.GetEncoding("Unicode")))
        {
            string line;
            while ((line = text.ReadLine()) != null)
            {
                string pattern = @"\bstart\b";
                string replace = "finish";
                line = Regex.Replace(line, pattern, replace);
            }
            using (StreamWriter edit = new StreamWriter("../../edit.text", false, Encoding.GetEncoding("Unicode")))
            {
                edit.Write(line);
            }
        }
    }
}
