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
                            // i. Provide user with menu options
                            Console.WriteLine("Please choose from the following options. ");
                            Console.WriteLine("Press 'L' to see list of accounts. ");
                            Console.WriteLine("Press 'D' to make a deposit. ");
                            Console.WriteLine("Press 'W' to make a withdrawal. ");
                            Console.WriteLine("Press 'R' to return to main menu. ");

                            // ii. Get user option choice
                            userChoiceString = Console.ReadLine();

                            // iii. Validate user option choice
                            userChoice = CheckInput(userChoiceString, new string[] { "l", "d", "w", "r" });

                            if (!userChoice)
                            {
                                Console.WriteLine("Please enter a valid option.");
                            }

                            // B. While input is invalid
                        } while (!userChoice);

                        // C. If option choice is 'List'
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

                        // D. Else if option choice is 'Deposit'
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

                        // E. Else if option choice is 'Withdrawal'
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

                        // F. Else the option choice is 'Return'
                    } while (!(userChoiceString == "R") && !(userChoiceString == "r"));

                } // end if for client options 


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