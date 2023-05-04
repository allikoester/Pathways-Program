namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>();
            bool userChoice;
            string? userChoiceString;
            int accountID;
            string? accountType;
            double accountBalance;
            double accountExtra;
            const string FileName = "accounts.txt";

            do
            {
                do
                {
                    Console.WriteLine("Please choose from the following options. ");
                    Console.WriteLine("Press 'C' to access client options. ");
                    Console.WriteLine("Press 'B' to access banking options. ");
                    Console.WriteLine("Press 'Q' to quit the program. ");

                    userChoiceString = Console.ReadLine();
                    userChoice = CheckInput(userChoiceString, new string[] { "c", "b", "q" });

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } // end do for client or bank
                while (!userChoice);

                // Client Options
                if (CheckInput(userChoiceString, new string[] { "C" }))
                {
                    do
                    {
                        do
                        {
                            // Provide user with menu options
                            Console.WriteLine("Please choose from the following options. ");
                            Console.WriteLine("Press 'L' to see list of accounts. ");
                            Console.WriteLine("Press 'D' to make a deposit. ");
                            Console.WriteLine("Press 'W' to make a withdrawal. ");
                            Console.WriteLine("Press 'R' to return to main menu. ");

                            // Get user option choice
                            userChoiceString = Console.ReadLine();

                            // Validate user option choice
                            userChoice = CheckInput(userChoiceString, new string[] { "l", "d", "w", "r" });

                            if (!userChoice)
                            {
                                Console.WriteLine("Please enter a valid option.");
                            }

                            // While input is invalid
                        } while (!userChoice);

                        // If option choice is 'List'
                        if (CheckInput(userChoiceString, new string[] { "L" }))
                        {
                            using var sr = File.OpenText(FileName);
                            {
                                // Load from text file and print 
                                while (((accountID = Convert.ToInt32(sr.ReadLine())) != null) && ((accountType = sr.ReadLine()) != null) &&
                                ((accountBalance = Convert.ToDouble(sr.ReadLine())) != null) && ((accountExtra = Convert.ToDouble(sr.ReadLine())) != null))
                                {
                                    if (accountType == "Savings")
                                    {
                                        Savings account = new Savings(accountID, accountType, accountBalance, accountExtra);
                                        accountList.Add(account);
                                    }
                                    else if (accountType == "Checking")
                                    {
                                        Checking account = new Checking(accountID, accountType, accountBalance, accountExtra);
                                        accountList.Add(account);
                                    }
                                    else if (accountType == "CD")
                                    {
                                        CD account = new CD(accountID, accountType, accountBalance, accountExtra);
                                        accountList.Add(account);
                                    }
                                }// end while 
                            } // end using sr OpenText
                            foreach (Account account in accountList)
                            {
                                Console.WriteLine(account.ToString());
                            }
                            Console.WriteLine(" ");
                        } // end List if

                        // Else if option choice is 'Deposit'
                        if (CheckInput(userChoiceString, new string[] { "D" }))
                        {
                            MakeTransaction(userChoiceString, accountList);

                            int index = 0;
                            using var sw = File.CreateText(FileName);
                            {
                                // Write to text file
                                foreach (Account account in accountList)
                                {
                                    accountList[index].WriteToFile(sw);
                                    index++;
                                }
                            }
                            Console.WriteLine(" ");
                        } // end Deposit if

                        // Else if option choice is 'Withdrawal'
                        if (CheckInput(userChoiceString, new string[] { "W" }))
                        {
                            MakeTransaction(userChoiceString, accountList);

                            int index = 0;
                            using var sw = File.CreateText(FileName);
                            {
                                // Write to text file
                                foreach (Account account in accountList)
                                {
                                    accountList[index].WriteToFile(sw);
                                    index++;
                                }
                            }
                            Console.WriteLine(" ");
                        } // end Withdrawal if 

                        //  Else the option choice is 'Return'
                    } while (!(userChoiceString == "R") && !(userChoiceString == "r"));

                } // end if for client options 

                // Bank Options
                if (CheckInput(userChoiceString, new string[] { "B" }))
                {
                    do
                    {
                        do
                        {
                            // Provide user with menu options
                            Console.WriteLine("Please choose from the following options. ");
                            Console.WriteLine("Press 'L' to load data into a list. ");
                            Console.WriteLine("Press 'P' to print all accounts in list. ");
                            Console.WriteLine("Press 'D' to make a deposit. ");
                            Console.WriteLine("Press 'W' to make a withdrawal. ");
                            Console.WriteLine("Press 'C' to add an account. ");
                            Console.WriteLine("Press 'U' to update an account. ");
                            Console.WriteLine("Press 'X' to delete an account. ");
                            Console.WriteLine("Press 'R' to return to main menu. ");

                            // Get user option choice
                            userChoiceString = Console.ReadLine();

                            // Validate user option choice
                            userChoice = CheckInput(userChoiceString, new string[] { "l", "p", "d", "w", "c", "u", "x", "r" });

                            if (!userChoice)
                            {
                                Console.WriteLine("Please enter a valid option.");
                            }
                            Console.WriteLine(" ");
                            //  While input is invalid
                        } while (!userChoice);

                        // Load
                        if (CheckInput(userChoiceString, new string[] { "L" }))

                        {
                            Console.WriteLine("In the L/l area");

                            using var sr = File.OpenText(FileName);
                            {
                                // Load from text file 
                                while (((accountID = Convert.ToInt32(sr.ReadLine())) != null) && ((accountType = sr.ReadLine()) != null) &&
                                ((accountBalance = Convert.ToDouble(sr.ReadLine())) != null) && ((accountExtra = Convert.ToDouble(sr.ReadLine())) != null))
                                {
                                    if (accountType == "Savings")
                                    {
                                        Savings account = new Savings(accountID, accountType, accountBalance, accountExtra);
                                        accountList.Add(account);
                                    }
                                    else if (accountType == "Checking")
                                    {
                                        Checking account = new Checking(accountID, accountType, accountBalance, accountExtra);
                                        accountList.Add(account);
                                    }
                                    else if (accountType == "CD")
                                    {
                                        CD account = new CD(accountID, accountType, accountBalance, accountExtra);
                                        accountList.Add(account);
                                    }
                                }// end while 
                            } // end using sr OpenText
                            Console.WriteLine("Data loaded. \n");

                        } // end if to load

                        // Else if 'Print'
                        if (CheckInput(userChoiceString, new string[] { "P" }))
                        {
                            foreach (Account account in accountList)
                            {
                                Console.WriteLine(account.ToString());
                            }
                            Console.WriteLine(" ");
                        } // end if Print option

                        // Else if option choice is 'Deposit'
                        if (CheckInput(userChoiceString, new string[] { "D" }))
                        {
                            MakeTransaction(userChoiceString, accountList);

                            int index = 0;
                            using var sw = File.CreateText(FileName);
                            {
                                // ii. Write to text file
                                foreach (Account account in accountList)
                                {
                                    accountList[index].WriteToFile(sw);
                                    index++;
                                }
                            }
                            Console.WriteLine(" ");
                        } // end Deposit if

                        // Else if option choice is 'Withdrawal'
                        if (CheckInput(userChoiceString, new string[] { "W" }))
                        {
                            MakeTransaction(userChoiceString, accountList);

                            int index = 0;
                            using var sw = File.CreateText(FileName);
                            {
                                // ii. Write to text file
                                foreach (Account account in accountList)
                                {
                                    accountList[index].WriteToFile(sw);
                                    index++;
                                }
                            }
                            Console.WriteLine(" ");
                        } // end Withdrawal if 

                        // Else if the option is 'Add' 
                        else if (CheckInput(userChoiceString, new string[] { "c" }))
                        {
                            Console.WriteLine("In the C/c area");

                            Console.WriteLine("Please enter new account ID. ");
                            accountID = Convert.ToInt32(Console.ReadLine());
                            if (accountID == null)
                            {
                                Console.WriteLine("Please enter a valid account ID. ");
                            }

                            Console.WriteLine("Please enter new account type. ");
                            accountType = Console.ReadLine();
                            if (string.IsNullOrEmpty(accountType))
                            {
                                Console.WriteLine("Please enter a valid account type. ");
                            }

                            Console.WriteLine("Please enter new account balance. ");
                            accountBalance = Convert.ToDouble(Console.ReadLine());
                            if (accountBalance == null)
                            {
                                Console.WriteLine("Please enter a valid account balance. ");
                            }

                            if (CheckInput(accountType, new string[] { "Savings" }))
                            {
                                Console.WriteLine("Please enter annual interest rate. ");
                                accountExtra = Convert.ToDouble(Console.ReadLine());
                                Savings newAccount = new Savings(accountID, accountType, accountBalance, accountExtra);
                                accountList.Add(newAccount);
                                Console.WriteLine(newAccount.ToString());
                            }

                            if (CheckInput(accountType, new string[] { "Checking" }))
                            {
                                Console.WriteLine("Please enter annual fee. ");
                                accountExtra = Convert.ToDouble(Console.ReadLine());
                                Savings newAccount = new Savings(accountID, accountType, accountBalance, accountExtra);
                                accountList.Add(newAccount);
                                Console.WriteLine(newAccount.ToString());
                            }

                            if (CheckInput(accountType, new string[] { "CD" }))
                            {
                                Console.WriteLine("Please enter annual interest rate. ");
                                accountExtra = Convert.ToDouble(Console.ReadLine());
                                Savings newAccount = new Savings(accountID, accountType, accountBalance, accountExtra);
                                accountList.Add(newAccount);
                                Console.WriteLine(newAccount.ToString());
                            }

                            int index = 0;
                            using var sw = File.CreateText(FileName);
                            {
                                // ii. Write to text file
                                foreach (Account account in accountList)
                                {
                                    accountList[index].WriteToFile(sw);
                                    index++;
                                }
                            }
                            Console.WriteLine(" ");
                        } // end Add if 

                        //  Else is the option is 'Update' 
                        else if (CheckInput(userChoiceString, new string[] { "u" }))
                        {
                            Console.WriteLine("In the U/u area");
                            string? userResponse;

                            Console.WriteLine("Please enter account ID to update. ");
                            int accountIDEntered = Convert.ToInt32(Console.ReadLine());

                            int index = FindIndex(accountIDEntered, accountList);
                            if (index == -1)
                            {
                                Console.WriteLine("Account ID not found. ");
                            }

                            else
                            {
                                Console.WriteLine("Press 'y' to update account ID. Any other key to continue. ");
                                userResponse = Console.ReadLine();
                                if ((userResponse == "y") || (userResponse == "Y"))
                                {
                                    Console.WriteLine("Please enter updated account ID. ");
                                    int accountIDUpdated = Convert.ToInt32(Console.ReadLine());
                                    accountList[index].AccountID = accountIDUpdated;
                                }
                                if (accountList[index].AccountType == "Savings")
                                {
                                    Console.WriteLine("Press 'y' to update annual interest rate. Any other key to continue. ");
                                    userResponse = Console.ReadLine();
                                    if ((userResponse == "y") || (userResponse == "Y"))
                                    {
                                        Console.WriteLine("Please enter updated annual interest rate. ");
                                        int accountExtraUpdated = Convert.ToInt32(Console.ReadLine());
                                        accountList[index].UpdateAccountExtra(accountExtraUpdated);
                                    }
                                }
                                if (accountList[index].AccountType == "Checking")
                                {
                                    Console.WriteLine("Press 'y' to update annual fee. Any other key to continue. ");
                                    userResponse = Console.ReadLine();
                                    if ((userResponse == "y") || (userResponse == "Y"))
                                    {
                                        Console.WriteLine("Please enter updated annual fee. ");
                                        int accountExtraUpdated = Convert.ToInt32(Console.ReadLine());
                                        accountList[index].UpdateAccountExtra(accountExtraUpdated);
                                    }
                                }
                                if (accountList[index].AccountType == "CD")
                                {
                                    Console.WriteLine("Press 'y' to update annual interest rate. Any other key to continue. ");
                                    userResponse = Console.ReadLine();
                                    if ((userResponse == "y") || (userResponse == "Y"))
                                    {
                                        Console.WriteLine("Please enter updated annual interest rate. ");
                                        int accountExtraUpdated = Convert.ToInt32(Console.ReadLine());
                                        accountList[index].UpdateAccountExtra(accountExtraUpdated);
                                    }
                                }
                                Console.WriteLine(accountList[index].ToString());
                                Console.WriteLine(" ");
                            } // end else if account found
                        } // end Update if

                        // Else if the options is 'Delete'
                        else if (CheckInput(userChoiceString, new string[] { "x" }))
                        {
                            Console.WriteLine("In the D/d area");

                            Console.WriteLine("Please enter account ID to delete. ");
                            int accountIDEntered = Convert.ToInt32(Console.ReadLine());

                            int index = FindIndex(accountIDEntered, accountList);
                            if (index == -1)
                            {
                                Console.WriteLine("Account not found. ");
                            }
                            else
                            {
                                Console.WriteLine("Press 'y' to delete " + accountList[index].AccountID);
                                string userInput = Console.ReadLine();
                                if ((userInput == "Y") || (userInput == "y"))
                                {
                                    accountList.Remove(accountList[index]);

                                    Console.WriteLine("Employee deleted. \n");
                                }
                            } // end else if account found
                            Console.WriteLine(" ");
                        } // end Delete if

                        // Else the option choice is 'Return'
                    } while (!(userChoiceString == "R") && !(userChoiceString == "r"));

                } // end if for Bank options 

            } // end main do for program
            while (!(userChoiceString == "Q") && !(userChoiceString == "q"));


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
        } // end MakeTransaction method


    } // end class
} // end namespace