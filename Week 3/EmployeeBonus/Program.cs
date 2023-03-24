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
        i. Open text file using streamWriter 
        ii. Foreach employee in employee array 
            a. Write to text file 
    E. Else if the option is 'Add' if there is room
        i. Declare variables
            a. For each employee in employee array
            b. If empty space
                I. Prompt user to input new employee first, last name, employment type, and compensation
                II. Get new items from the user
                III. Assign to hourly or salary
                IV. Calculate bonus
                V. Print out new employee information
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
            Employee[] employeeArray = new Employee[25];
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
                        double compensation;

                        // b. Write to the console the file is open
                        Console.WriteLine(" Here is the content of the file employees.txt : ");

                        // c. Write to console the text file and load into arrays
                        while (((firstName = sr.ReadLine()) != null) && ((lastName = sr.ReadLine()) != null) && ((employmentType = sr.ReadLine()) != null) && (compensation = Convert.ToDouble(sr.ReadLine())) != null)
                        {
                            Console.WriteLine(firstName);
                            Console.WriteLine(lastName);
                            Console.WriteLine(employmentType);
                            Console.WriteLine(compensation);
                            if (CheckInput(employmentType, new string[] { "h" }))
                            {
                                Hourly temp = new Hourly(firstName, lastName, employmentType, compensation);
                                employeeArray[index] = temp;
                            }
                            else if (CheckInput(employmentType, new string[] { "s" }))
                            {
                                Salary temp = new Salary(firstName, lastName, employmentType, compensation);
                                employeeArray[index] = temp;
                            }
                            index++;
                        }
                        Console.WriteLine(" ");
                    }
                }

                // D. Else if the option is 'Save'
                else if (CheckInput(userChoiceString, new string[] { "s" }))
                {
                    Console.WriteLine("In the S/s area");

                    // i. Open text file using streamWriter 
                    using var sw = File.CreateText(FileName);
                    {
                        // ii. Foreach employee in Employee array 
                        foreach (Employee employee in employeeArray)
                        {
                            if (employee.FirstName != " ")
                            {
                                // a. Write to text file
                                sw.WriteLine(employee.FirstName);
                                sw.WriteLine(employee.LastName);
                                sw.WriteLine(employee.TypeEmployment);
                                sw.WriteLine(employee.Compensation);
                            }
                        }
                        Console.WriteLine("Text file saved. ");
                        Console.WriteLine("");
                    }
                }

                // E. Else if the option is 'Add' if there is room
                else if (CheckInput(userChoiceString, new string[] { "c" }))
                {
                    Console.WriteLine("In the C/c area");

                    // i. Declare variables
                    string? firstName;
                    string? lastName;
                    string? employmentType;
                    double compensation;
                    double bonus;
                    int index = 0;
                    bool foundOne = false;

                    // ii. For each employee in employee array
                    foreach (Employee employee in employeeArray)
                    {
                        // a. If empty space
                        if (employee == null)
                        {
                            // I. Prompt user to input new employee first, last name, employment type, and compensation
                            // II. Get new items from the user
                            Console.WriteLine("Please enter new employee first name. ");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Please enter new employee last name. ");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Please enter new employee, employment type. Either H or S. ");
                            employmentType = Console.ReadLine();

                            /// III. Assign to hourly or salary
                            // IV. Calculate bonus
                            if (CheckInput(employmentType, new string[] { "h" }))
                            {
                                Console.WriteLine("Please enter new employee hourly wage. ");
                                compensation = Convert.ToDouble(Console.ReadLine());
                                Hourly newEmployee = new Hourly(firstName, lastName, employmentType, compensation);
                                employeeArray[index] = newEmployee;
                                bonus = employeeArray[index].CalculateBonus(compensation);
                            }
                            else if (CheckInput(employmentType, new string[] { "s" }))
                            {
                                Console.WriteLine("Please enter new employee annual salary. ");
                                compensation = Convert.ToDouble(Console.ReadLine());
                                Salary newEmployee = new Salary(firstName, lastName, employmentType, compensation);
                                employeeArray[index] = newEmployee;
                                bonus = employeeArray[index].CalculateBonus(compensation);
                            }
                            Console.WriteLine(employee);
                            foundOne = true;
                            break;
                        }
                    }
                    // b. If no empty space, provide error
                    if (!foundOne)
                    {
                        Console.WriteLine("Index if full. ");
                        Console.WriteLine(" ");
                    }
                }

                //  F. Else is the option is 'Read/Print'
                else if (CheckInput(userChoiceString, new string[] { "r" }))
                {
                    Console.WriteLine("In the R/r area");

                    // i. For each Employee
                    foreach (Employee employee in employeeArray)
                    {
                        // a. If the space is not null
                        if (employee != null)
                        {
                            // I. Calculate bonus and print out employee information
                            double bonus = employee.CalculateBonus(employee.Compensation);
                            Console.WriteLine(employee);
                        }

                    }
                    // b. If there are no Employees listed
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
