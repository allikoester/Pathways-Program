using System;
using System.IO;

class Test2
{
    public static void Main2()
    {
        string path = "mytestb.txt";
        // if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Hello Again");
                sw.WriteLine("And");
                sw.WriteLine("Welcome Again");
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}