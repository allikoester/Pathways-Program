using System;
using System.Collections.Generic;

class Geeks
{

    // Main Method
    public static void Main(String[] args)
    {

        // Creating a List of integers
        List<int> firstlist = new List<int>();

        // displaying the number
        // of elements of List<T>
        Console.WriteLine(firstlist.Count);
        Console.WriteLine(firstlist.Capacity);

        firstlist.Add(35);
        firstlist.Add(24);

        Console.WriteLine(firstlist.Count);
        Console.WriteLine(firstlist.Capacity);

        firstlist.Add(12);
        firstlist.Add(90);

        Console.WriteLine(firstlist.Count);
        Console.WriteLine(firstlist.Capacity);

        firstlist.Add(28);
        firstlist.Add(77);

        Console.WriteLine(firstlist.Count);
        Console.WriteLine(firstlist.Capacity);

        Console.WriteLine(firstlist.Contains(4));
        Console.WriteLine(firstlist.Contains(35));

        foreach (int listItem in firstlist)
        {
            Console.WriteLine(listItem);
        }

        // for (int index = 0; index < firstlist.Count; index++)
        // {
        //     Console.WriteLine(firstlist[index]);
        // }

        // firstlist.Remove(35);
        // for (int index = 0; index < firstlist.Count; index++)
        // {
        //     Console.WriteLine(firstlist[index]);
        // }

        // firstlist.RemoveAll(item => item == 35);
        // for (int index = 0; index < firstlist.Count; index++)
        // {
        //     Console.WriteLine(firstlist[index]);
        // }

        firstlist.Sort();
        foreach (int listItem in firstlist)
        {
            Console.WriteLine(listItem.ToString());
        }

        Console.WriteLine(firstlist.TrueForAll(item => item > 12));


    }
}