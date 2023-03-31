/*

Developer Name: Alli Koester
Last Update: 3/30/23

Program Description: Create list of accounts for user including savings, checking, and CD. 
    Allow user print out accounts with associated information. 
    Allow user to perform a deposit. 
    Allow user to perform a withdrawal. 
    Allow user to quit transaction processing. 

Requirements:
    (1) Integers -- Account ID
    (2) Strings -- Account type
    (3) Double -- Account balance, Annual interest rate, and Annual fee

Algorithm: 
    I. Create list
    II. Add accounts to list
    III. Do 
        A. Do 
            i. Provide user with menu options
            ii. Get user option choice
            iii. Validate user option choice
        B. While input is invalid
        C. If option choice is 'List'
            i. Foreach account
                a. Print to console account with associated information 
        D. Else if option choice is 'Deposit'
            i. Do
                a. Prompt user for account ID
                b. Get account ID from user
                c. Find account index if in list
                While account ID is invalid
            ii. Do
                a. Prompt user for deposit amount
                b. Get deposit amount from user 
                While deposit is invalid
            vi. Make deposit  
        E. Else if option choice is 'Withdrawal'
            i. Do
                a. Prompt user for account ID
                b. Get account ID from user
                c. Find account index if in list
                While account ID is invalid
            ii. Do 
                iii. Prompt user for withdrawal amount
                iv. Get withdrawal amount from user 
                While withdrawal amount is invalid
            iii. Make withdrawal 
        F. Else the option choice is 'Quit'

*/


namespace BankClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // I. Create list
            List<Account> accountList = new List<Account>();

            // II. Add accounts to list
            Savings account1 = new Savings(1234, "Savings", 12500.00, 2.5);
            accountList.Add(account1);

            Checking account2 = new Checking(2345, "Checking", 5500.00, 50.00);
            accountList.Add(account2);

            CD account3 = new CD(3456, "CD", 10000.00, 5);
            accountList.Add(account3);

            bool userChoice;
            string userChoiceString;
            int accountID;

            // III. Do 
            do
            {
                // A. Do 
                do
                {
                    // i. Provide user with menu options
                    Console.WriteLine("Please choose from the following options. ");
                    Console.WriteLine("Press 'L' to see list of accounts. ");
                    Console.WriteLine("Press 'D' to make a deposit. ");
                    Console.WriteLine("Press 'W' to make a withdrawal. ");
                    Console.WriteLine("Press 'Q' to quit program. ");

                    // ii. Get user option choice
                    userChoiceString = Console.ReadLine();

                    // iii. Validate user option choice
                    userChoice = CheckInput(userChoiceString, new string[] { "l", "d", "w", "q" });

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                    // B. While input is invalid
                } while (!userChoice);

                // C. If option choice is 'List'
                if (CheckInput(userChoiceString, new string[] { "L" }))
                {
                    // i. Foreach account
                    foreach (Account account in accountList)
                    {
                        // a. Print to console account with associated information 
                        Console.WriteLine(account.ToString());
                    } // end List foreach
                    Console.WriteLine(" ");
                } // end List if

                // D. Else if option choice is 'Deposit'
                else if (CheckInput(userChoiceString, new string[] { "D" }))
                {
                    MakeTransaction(userChoiceString, accountList);

                    Console.WriteLine(" ");
                } // end Deposit if

                // E. Else if option choice is 'Withdrawal'
                else if (CheckInput(userChoiceString, new string[] { "W" }))
                {
                    MakeTransaction(userChoiceString, accountList);

                    Console.WriteLine(" ");

                } // end Withdrawal if 

                // F. Else the option choice is 'Quit'
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

        static int FindIndex(int accountID, List<Account> accountList)
        {
            int index = -1;
            if (accountID == null)
            {
                Console.WriteLine("Please enter a valid account ID. ");
            }
            else
            {
                index = accountList.FindIndex(account => account.AccountID == accountID);
            }

            return index;
        } // end FindIndex method

        static void MakeTransaction(string userInput, List<Account> accountList)
        {
            int index;
            int accountID;
            double transactionAmount;
            // i. Do 
            do
            {
                // a. Prompt user for account ID
                Console.WriteLine("Please enter account ID. ");

                // b. Get account ID from user
                accountID = Convert.ToInt32(Console.ReadLine());

                // c. Find account index
                index = FindIndex(accountID, accountList);
                if (index == -1)
                {
                    Console.WriteLine("Account not found. ");
                }
                // While account ID is invalid
            } while (index == -1);

            // ii. Do
            do
            {
                // a. Prompt user for deposit amount
                Console.WriteLine("Please enter transaction amount. ");

                // b. Get deposit amount from user 
                transactionAmount = Convert.ToDouble(Console.ReadLine());

                if (transactionAmount <= 0)
                {
                    Console.WriteLine("Please enter a valid amount greater than zero. ");
                }

                // While deposit is invalid
            } while (transactionAmount <= 0);

            if ((userInput == "D") || (userInput == "d"))
            {
                accountList[index].Deposit(accountID, transactionAmount);
            }
            else if ((userInput == "W") || (userInput == "w"))
            {
                accountList[index].Withdrawal(accountID, transactionAmount);
            }
        }

    } // end class
} // end namespace