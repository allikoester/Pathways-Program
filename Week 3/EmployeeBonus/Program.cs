/*

Developer Name: Alli Koester
Last Update: 3/23/23

Program Description: Use text file to store employee first name, last name, type of employment (hourly or salary), and bonus amount. 
    Program will calculate bonus amount based on employment type (hourly or salary). 
    User will be able to load text file into program, store current employee information, add an employee, print a list of employees,
    and delete an employee. 

Requirements:
    (1) First name, last name, and type of employement will be strings
    (2) Employee wages and bonus will be doubles

Algorithm: 
I. Declare variables
II. Do 
    A. Do 
        i. Provide user with menu options
        ii. Get user option choice
        iii. Validate user option choice
    B. While input is invalid
    C. If option choice is 'Load'
        i. Declare variables
        ii. Open text file using streamReading
            a. Declare variables
            b. Write to the console the file is open
            c. Write to console the text file and load into arrays
    D. Else if the option is 'Save'
        i. Declare variables
        ii. Open text file using streamWriter 
        iii. Foreach employee in employee array 
            a. Write to text file 
    E. Else if the option is 'Add' if there is room
            b. For each employee in employee array
            a. If empty space
                I. Prompt user to input new employee first and last name
                II. Get new employee name from the user
                III. Prompt user to input type of employement (H or S)
                IV. Get type of employment from the user
                V. Calculate bonus amount
                VI. Write to console new employee information
            b. If no empty space, provide error
    F. Else is the option is 'Read/Print'
        i. For each employee
            a. If the space is not null
                I. Calcualte bonus and print out employee information
            b. If there are no employees listed
                I. Provide error
    G. Else is the option is 'Update' 
        i. Prompt user for name of employee
        ii. Get name of employee from user
            a. If employee is in array 
                I. Does user want to change empoloyee first name?
                    A. If yes, update first name
                II. Does user want to change employee last name?
                    A. If yes, update last name 
                III. Does user want to change type of employment? 
                    A. If yes, update type of employment
                IV. Does user want to change compensation amount? 
                    A. If yes, update compensation
                V. Calculate bonus
                VI. Write to console employee infomration
            b. If not error
    F. Else if the options is 'Delete'
        i. Prompt user for name of employee
        ii. Get name of employee from user
            a. If employee is in array 
                I. Delete employee first name
                II. Delete employee last name
                III. Delete employee type of employment
                IV. Delete employee bonus
            b. If not error
    H. Else the option is 'Quit' 

*/

namespace EmployeeBonus
{

    class Program
    {

        static void Main(string[] args)
        {
            // I. Declare variables
            bool userChoice;
            string userChoiceString;
            Employee[] employeeArray = new Employee[10];
            // int[] ratings = new int[25];
            const string FileName = "employees.txt";

            // II. Do 
            do
            {

                // A. Do
                do
                {

                    // i. Provide user with menu options
                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("L: Load the data file into an array.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read from the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete a name from the array.");
                    Console.WriteLine("Q: Quit the program.");

                    // ii. Get user option choice
                    userChoiceString = Console.ReadLine();

                    // iii. Validate user option choice
                    userChoice = CheckInput(userChoiceString, new string[] { "l", "s", "c", "r", "u", "d", "q" });

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                    // B. While input is invalid
                } while (!userChoice);

                //  C. If option choice is 'Load'
                if (CheckInput(userChoiceString, new string[] { "L" }))

                {
                    Console.WriteLine("In the L/l area");

                    // i. Declare variables
                    int index = 0;

                    // ii. Open text file using streamReading
                    using var sr = File.OpenText(FileName);
                    {
                        // a. Declare variables
                        string? firstName;
                        string? lastName;
                        string? employmentType;
                        double? compensation;


                        // b. Write to the console the file is open
                        Console.WriteLine(" Here is the content of the file employees.txt : ");

                        // c. Write to console the text file and load into arrays
                        while (((firstName = sr.ReadLine()) != null) && ((lastName = sr.ReadLine()) != null) && ((employmentType = sr.ReadLine()) != null) && (compensation = Convert.ToDouble(sr.ReadLine())) != null)
                        {
                            Console.WriteLine(firstName);
                            Console.WriteLine(lastName);
                            Console.WriteLine(employmentType);
                            Console.WriteLine(compensation);
                            index++;
                        }
                        Console.WriteLine(" ");
                    }
                }








                //  F. Else is the option is 'Read/Print'
                else if (CheckInput(userChoiceString, new string[] { "r" }))
                {
                    Console.WriteLine("In the R/r area");

                    int index = 0;
                    double compensation;

                    // i. For each Employee
                    foreach (Employee employee in employeeArray)
                    {
                        // a. If the space is not null
                        if (employee.FirstName != null)
                        {
                            // I. Calculate bonus and print out employee information
                            double bonus = employee.CalculateBonus(employee.compensation);
                            Console.WriteLine(employee);
                        }

                    }
                    // b. If there are no Employees  listed
                    if (employeeArray.Length == 0)
                    {
                        // I. Provide error
                        Console.WriteLine("There are no employees in the list. ");
                    }
                }





                else
                {
                    Console.WriteLine("Good-bye!");
                }
            } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
        } // end Main

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
        } // end CheckInput method 


    } // end class
} // end namespace
