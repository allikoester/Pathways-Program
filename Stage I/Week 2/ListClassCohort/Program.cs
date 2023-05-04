using System;
using System.Collections.Generic;

namespace ListClassCohort
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            bool userChoice;
            string userChoiceString;
            List<string> nameList = new List<string>();
            const string FileName = "names.txt";

            // Repeat main loop
            do
            {

                // TODO: Get a valid input
                do
                {

                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("L: Load the data file into the list.");
                    Console.WriteLine("S: Save the list to the data file.");
                    Console.WriteLine("C: Add a name to the list.");
                    Console.WriteLine("R: Read a name from the list.");
                    Console.WriteLine("U: Update a name in the list.");
                    Console.WriteLine("D: Delete a name from the list.");
                    Console.WriteLine("Q: Quit the program.");

                    //  TODO: Get a user option (valid means its on the menu)

                    userChoiceString = Console.ReadLine();

                    userChoice = CheckInput(userChoiceString, new string[] { "l", "s", "c", "r", "u", "d", "q" });

                    // (userChoiceString == "L" || userChoiceString == "l" ||
                    // userChoiceString == "S" || userChoiceString == "s" ||
                    // userChoiceString == "C" || userChoiceString == "c" ||
                    // userChoiceString == "R" || userChoiceString == "r" ||
                    // userChoiceString == "U" || userChoiceString == "u" ||
                    // userChoiceString == "D" || userChoiceString == "d" ||
                    // userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } while (!userChoice);

                //  TODO: If the option is L or l then load the text file (names.txt) into the list of strings (nameList)

                if (CheckInput(userChoiceString, new string[] { "l" }))
                // if (userChoiceString == "L" || userChoiceString == "l")
                {
                    Console.WriteLine("In the L/l area");

                    using (var sr = File.OpenText(FileName))
                    {

                        Console.WriteLine(" Here is the content of the file names.txt : ");
                        string name;
                        while ((name = sr.ReadLine()) != null)
                        {
                            nameList.Add(name);
                        }
                        foreach (string s in nameList)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                //  TODO: Else if the option is an S or s then store the list of strings into the text file

                else if (CheckInput(userChoiceString, new string[] { "s" }))
                {
                    Console.WriteLine("In the S/s area");

                    // using (StreamWriter sw = File.CreateText(FileName))
                    int index = 0;
                    using var sw = File.CreateText(FileName);
                    foreach (string name in nameList)
                    {
                        if (!string.IsNullOrEmpty(nameList[index]))
                        {
                            sw.WriteLine(name);
                        }
                    }

                    Console.WriteLine("Text file saved. ");
                    Console.WriteLine("");
                }

                //  TODO: Else if the option is a C or c then add a name to the list


                else if (CheckInput(userChoiceString, new string[] { "c" }))
                {
                    Console.WriteLine("In the C/c area");

                    string newName;

                    Console.WriteLine("Please enter new name. ");
                    newName = Console.ReadLine();
                    if (string.IsNullOrEmpty(newName))
                    {
                        Console.WriteLine("Please enter a valid name. ");
                    }
                    nameList.Add(newName);
                }

                //  TODO: Else if the option is an R or r then print the list

                else if (CheckInput(userChoiceString, new string[] { "r" }))
                {
                    Console.WriteLine("In the R/r area");

                    foreach (string name in nameList)
                    {
                        Console.WriteLine(name);
                    }
                }
                //  TODO: Else if the option is a U or u then update a name in the list
                // Get name first from user
                // Is name in list 
                // If not error
                // If yes, what do you want to change to 

                else if (CheckInput(userChoiceString, new string[] { "u" }))
                {
                    Console.WriteLine("In the U/u area");

                    Console.WriteLine("Please enter name of student to update. ");
                    string nameEntered = Console.ReadLine();
                    int index = FindIndex(nameEntered, nameList);
                    if (index == -1)
                    {
                        Console.WriteLine("Name not found. ");
                    }
                    else
                    {
                        Console.WriteLine("What would you like to update name to? ");
                        string nameUpdated = Console.ReadLine();
                        nameList.Remove(nameEntered);
                        nameList.Insert(index, nameUpdated);
                    }

                }


                //  TODO: Else if the option is a D or d then delete the name in the list (if it's there)
                // Get name from user
                // is name in array
                // If not error
                // If yes, change to null 

                else if (CheckInput(userChoiceString, new string[] { "d" }))
                {
                    Console.WriteLine("In the D/d area");
                    Console.WriteLine("Please enter name of student to delete. ");
                    string nameEntered = Console.ReadLine();
                    int index = FindIndex(nameEntered, nameList);
                    if (index == -1)
                    {
                        Console.WriteLine("Name not found. ");
                    }
                    else
                    {
                        index = nameList.IndexOf(nameEntered);
                        nameList.Remove(nameEntered);
                    }
                }

                //  TODO: Else if the option is a Q or q then quit the program

                else
                {
                    Console.WriteLine("Good-bye!");
                }
            } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
        }  // end main

        static bool CheckInput(string? input, string[] validValues)
        {
            if (string.IsNullOrEmpty(input)) return false;

            for (int i = 0; i < validValues.Length; i++)
            {
                if (validValues[i].ToUpper() == input.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        static int FindIndex(string nameEntered, List<string> nameList)
        {
            // List<string> nameList = new List<string>();
            int index = -1;
            if (string.IsNullOrEmpty(nameEntered))
            {
                Console.WriteLine("Please enter a valid name. ");
            }
            else if (nameList.Contains(nameEntered))
            {
                index = nameList.IndexOf(nameEntered);
            }

            return index;
        }

    }  // end program
}  // end namespace
