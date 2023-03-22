namespace ArrayClassCohort
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            bool userChoice;
            string userChoiceString;
            string[] nameArray = new string[10];
            const string FileName = "names.txt";

            // Repeat main loop
            do
            {

                // TODO: Get a valid input
                do
                {
                    //  Initialize variables

                    // userChoice = false;

                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("L: Load the data file into an array.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read a name from the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete a name from the array.");
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

                //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

                if (CheckInput(userChoiceString, new string[] { "l" }))
                // if (userChoiceString == "L" || userChoiceString == "l")
                {
                    Console.WriteLine("In the L/l area");

                    int index = 0;  // index for my array
                    using (StreamReader sr = File.OpenText(FileName))
                    {
                        string s = "";
                        Console.WriteLine(" Here is the content of the file names.txt : ");
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                            nameArray[index] = s;
                            index = index + 1;
                        }
                        Console.WriteLine("");
                    }
                }

                //  TODO: Else if the option is an S or s then store the array of strings into the text file

                else if (CheckInput(userChoiceString, new string[] { "s" }))
                {
                    Console.WriteLine("In the S/s area");

                    // using (StreamWriter sw = File.CreateText(FileName))
                    int index = 0;
                    using var sw = File.CreateText(FileName);
                    foreach (string s in nameArray)
                    {
                        if (!string.IsNullOrEmpty(nameArray[index]))
                        {
                            sw.WriteLine(s);
                        }
                    }

                    Console.WriteLine("Text file saved. ");
                    Console.WriteLine("");
                }

                //  TODO: Else if the option is a C or c then add a name to the array (if there's room)
                // Is there room -- loop to compare to see if empty -- Do, while 
                //If empty need to know index
                // no space -- all full, error
                // Give a string then add to index

                else if (CheckInput(userChoiceString, new string[] { "c" }))
                {
                    Console.WriteLine("In the C/c area");

                    string newName;
                    bool foundOne = false;

                    for (int index = 0; index < 10; index++)
                    {
                        if (string.IsNullOrEmpty(nameArray[index]))
                        {
                            Console.WriteLine("Please enter new name. ");
                            newName = Console.ReadLine();
                            nameArray[index] = newName;
                            foundOne = true;
                            break;
                        }
                    }
                    if (!foundOne)
                    {
                        Console.WriteLine("Index if full. ");
                        Console.WriteLine(" ");
                    }
                }

                //  TODO: Else if the option is an R or r then print the array

                else if (CheckInput(userChoiceString, new string[] { "r" }))
                {
                    Console.WriteLine("In the R/r area");
                    for (int index = 0; index < 10; index++)
                    {
                        if (!string.IsNullOrEmpty(nameArray[index]))
                        {
                            Console.WriteLine(nameArray[index]);
                        }

                    }

                }
                //  TODO: Else if the option is a U or u then update a name in the array (if it's there)
                // Get name first from user
                // Is name in array 
                // If not error
                // If yes, what do you want to change to 

                else if (CheckInput(userChoiceString, new string[] { "u" }))
                {
                    Console.WriteLine("In the U/u area");
                    Console.WriteLine("Please enter name of student to update. ");
                    string nameEntered = Console.ReadLine();
                    bool foundOne = false;

                    for (int index = 0; index < nameArray.Length; index++)
                    {
                        if (nameArray[index] == nameEntered)
                        {
                            Console.WriteLine("What would you like to update name to? ");
                            string nameUpdated = Console.ReadLine();
                            nameArray[index] = nameUpdated;
                            foundOne = true;
                            break;
                        }
                    }
                    if (!foundOne)
                    {
                        Console.WriteLine("Name entered does not match a name on the list. ");
                    }

                }

                //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)
                // Get name from user
                // is name in array
                // If not error
                // If yes, change to null 

                else if (CheckInput(userChoiceString, new string[] { "d" }))
                {
                    Console.WriteLine("In the D/d area");
                    Console.WriteLine("Please enter name of student to delete. ");
                    string nameEntered = Console.ReadLine();
                    bool foundOne = false;

                    for (int index = 0; index < nameArray.Length; index++)
                    {
                        if (nameArray[index] == nameEntered)
                        {
                            nameArray[index] = string.Empty;
                            foundOne = true;
                            break;
                        }
                    }
                    if (!foundOne)
                    {
                        Console.WriteLine("Name entered does not match a name on the list. ");
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
    }  // end program
}  // end namespace