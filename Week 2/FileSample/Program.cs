using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = "mytestb.txt";
        string[] stringTest = new string[10];

        if (!File.Exists(path))
        {

            Console.WriteLine("Sorry file not found.");
        }

        // Open the file to read from.
        else
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int index = 0;

                while ((s = sr.ReadLine()) != null)
                {
                    stringTest[index] = s;
                    index++;
                }
            }
        }
        foreach (string s in stringTest)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine("Please enter a new string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Please enter an index: ");
        int ind = Convert.ToInt32(Console.ReadLine());

        stringTest[ind] = str;
        foreach (string s in stringTest)
        {
            Console.WriteLine(s);
        }
        using (StreamWriter sw = File.CreateText(path))
        {
            foreach (string s in stringTest)
            {
                sw.WriteLine(s);
            }
        }
    }
}