/*

Developer Name: Alli Koester
Last Update: 4/4/23

Program Description: Create list of memberships for user including Regular, Executive, NonProfit, and Corporate
    Provide menu for administrative options and transaction options to include: 
        Create new membership
        Read list of memberships
        Update a membership
        Delete a membership
        Perform a purchase transaction
        Perform a return transaction
        Apply cashback 

Requirements:
    (1) Integers -- membership ID
    (2) Strings -- Primary contact email
    (3) Double -- Annual cost, current amount purchased, cash back percent 

Algorithm: 
    I. Create list
    II. Add accounts to list
    III. Do 
        A. Do 
            i. Provide user with menu options for administrative or transaction or quit
            ii. Get user option choice
            iii. Validate user option choice
            while user choice is invalid 
            iv. if option is 'Administrative' 
                a. Do
                    I. Do 
                        A. Provide user with menu options
                        B. Get user option choice
                        C. Validate user option choice
                        While user choice is invalid 
                    II. If option is 'Create' new membership
                        A. Do
                            i. Prompt user for new member ID
                            ii. Get new member ID
                            iii. Validate member ID
                            While member ID invalid 
                        B. Prompt/get new contact email address
                        C. Prompt/get new membership type
                        D. Prompt/get new annual cost
                        E. Prompt/get new amount purchased
                        F. Add to list 
                    III. If option is 'Read' 
                        A. For each membership in list
                            i. Write to console 
                    IV. If option is 'Update'
                        A. Do
                            i. Prompt/get member ID from user
                            ii. Find member index if in list
                            While member ID is invalid
                        B. Prompt to update membership ID
                        C. Prompt to update email address
                        D. Prompt to update membership type
                        E. Prompt to update annual cost
                        F. Prompt to update current amount purchased 
                    V. If option is 'Delete'
                        A. Do
                            i. Prompt/get member ID from user
                            ii. Find member index if in list
                            While member ID is invalid
                        B. Delete from list 
                While option is not 'Return'
            iv. If option is 'Transaction' 
                a. Do
                    I. Do 
                        A. Provide user with menu options
                        B. Get user option choice
                        C. Validate user option choice
                        While user choice is invalid 
                    II. If option is 'List' 
                        A. Foreach membership in List
                            i. Write to console 
                    III. If option is 'Purchase' 
                        A. Do
                            i. Prompt/get member ID from user
                            ii. Find member index if in list
                            While member ID is invalid
                        B. Make purchase 
                    IV. If option is 'Return' 
                        A. Do
                            i. Prompt/get member ID from user
                            ii. Find member index if in list
                            While member ID is invalid
                        B. Make return 
                    V. If option is 'Apply Cashback'
                        A. Do
                            i. Prompt/get member ID from user
                            ii. Find member index if in list
                            While member ID is invalid
                        B. Apply for cashback 
                While option is not 'Return'  
        B. While input is not quit

*/


namespace Membership
{
    class Program
    {
        static void Main(string[] args)
        {

            // I. Create list
            List<Membership> membershipList = new List<Membership>();
            bool userChoice;
            string? userChoiceString;
            int memberID;
            string memberEmail;
            string membershipType;
            double annualCost;
            double amountPurchased;
            double cashBackPercent;

            // II. Add members to list 
            Regular member1 = new Regular(3, 1234, "member1@gmail.com", "Regular", 60, 200);
            membershipList.Add(member1);

            Executive member2 = new Executive(5, 2345, "member2@gmail.com", "Executive", 120, 500);
            membershipList.Add(member2);

            Executive member3 = new Executive(5, 2346, "member3@gmail.com", "Executive", 120, 1500);
            membershipList.Add(member3);

            NonProfit member4 = new NonProfit(4, 3456, "member4@gmail.com", "NonProfit", 100, 800);
            membershipList.Add(member4);

            Corporate member5 = new Corporate(3.5, 4567, "member5@gmail.com", "Corporate", 125, 750);
            membershipList.Add(member5);

            // III. Do 
            do
            {
                // A. Do 
                do
                {
                    // i. Provide user with menu options for administrative or transaction or quit
                    Console.WriteLine("Please choose from following options. ");
                    Console.WriteLine("Press 'A' to access administrative options. ");
                    Console.WriteLine("Press 'T' for transaction options. ");
                    Console.WriteLine("Press 'Q' to quit the program. ");

                    // ii. Get user option choice
                    userChoiceString = Console.ReadLine();

                    // iii. Validate user option choice
                    userChoice = CheckInput(userChoiceString, new string[] { "a", "t", "q" });
                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                } // end do for Administrative or transaction
                  // while user choice is invalid 
                while (!userChoice);


                // iv. if option is 'Administrative' 
                if (CheckInput(userChoiceString, new string[] { "A" }))
                {
                    // a. Do
                    do
                    {
                        // I. Do 
                        do
                        {
                            // A. Provide user with menu options
                            Console.WriteLine("Please choose from the following administrative options. ");
                            Console.WriteLine("Press 'C' to create new membership. ");
                            Console.WriteLine("Press 'L' to list all memberships. ");
                            Console.WriteLine("Press 'U' to update membership. ");
                            Console.WriteLine("Press 'D' to delete a membership. ");
                            Console.WriteLine("Press 'B' to go back to main menu. ");

                            // B. Get user option choice
                            userChoiceString = Console.ReadLine();

                            // C. Validate user option choice
                            userChoice = CheckInput(userChoiceString, new string[] { "c", "l", "u", "d", "b" });

                            if (!userChoice)
                            {
                                Console.WriteLine("Please enter a valid option.");
                            }

                            // While user choice is invalid 
                        } // end do for administrative options 
                        while (!userChoice);

                        // II. If option is 'Create' new membership
                        if (CheckInput(userChoiceString, new string[] { "C" }))
                        {
                            // A. Do
                            do
                            {
                                // i. Prompt user for new member ID
                                Console.WriteLine("Please enter new member ID. ");

                                // ii. Get new member ID
                                memberID = Convert.ToInt32(Console.ReadLine());

                                // iii. Validate member ID
                                if (memberID == null)
                                {
                                    Console.WriteLine("Please enter a valid member ID. ");
                                }
                                foreach (Membership member in membershipList)
                                {
                                    if (member.MemberID == memberID)
                                    {
                                        Console.WriteLine("Member ID currently in use. Please enter new ID. ");
                                    }
                                }
                            }
                            // While member ID invalid 
                            while ((memberID == null));

                            // B. Prompt/get new contact email address
                            do
                            {
                                Console.WriteLine("Please enter new contact email address. ");
                                memberEmail = Console.ReadLine();
                                if (string.IsNullOrEmpty(memberEmail))
                                {
                                    Console.WriteLine("Please enter valid email address. ");
                                }
                            } while (string.IsNullOrEmpty(memberEmail));

                            // C. Prompt/get new membership type

                            do
                            {
                                Console.WriteLine("Please select membership type. ");
                                Console.WriteLine("Press 'R' for Regular membership. ");
                                Console.WriteLine("Press 'E' for Executive membership. ");
                                Console.WriteLine("Press 'N' for NonProfit membership. ");
                                Console.WriteLine("Press 'C' for Corporate membership. ");

                                userChoiceString = Console.ReadLine();
                                userChoice = CheckInput(userChoiceString, new string[] { "r", "e", "n", "c" });
                                if (!userChoice)
                                {
                                    Console.WriteLine("Please enter a valid option.");
                                }
                            } while (!userChoice);

                            // D. Prompt/get new annual cost
                            // E. Prompt/get new amount purchased
                            // F. Add to list 

                            if (CheckInput(userChoiceString, new string[] { "r" }))
                            {
                                annualCost = GetAnnualCost();
                                amountPurchased = GetAmountPurchased();
                                cashBackPercent = GetCashBackPercent();

                                Regular newMember = new Regular(cashBackPercent, memberID, memberEmail, "Regular", annualCost, amountPurchased);
                                membershipList.Add(newMember);
                                Console.WriteLine(newMember.ToString());
                                Console.WriteLine(" ");
                            } // end if Regular

                            if (CheckInput(userChoiceString, new string[] { "e" }))
                            {
                                annualCost = GetAnnualCost();
                                amountPurchased = GetAmountPurchased();
                                cashBackPercent = GetCashBackPercent();

                                Executive newMember = new Executive(cashBackPercent, memberID, memberEmail, "Executive", annualCost, amountPurchased);
                                membershipList.Add(newMember);
                                Console.WriteLine(newMember.ToString());
                                Console.WriteLine(" ");
                            } // end if Executive

                            if (CheckInput(userChoiceString, new string[] { "n" }))
                            {
                                annualCost = GetAnnualCost();
                                amountPurchased = GetAmountPurchased();
                                cashBackPercent = GetCashBackPercent();

                                NonProfit newMember = new NonProfit(cashBackPercent, memberID, memberEmail, "NonProfit", annualCost, amountPurchased);
                                membershipList.Add(newMember);
                                Console.WriteLine(newMember.ToString());
                                Console.WriteLine(" ");
                            } // end if Nonprofit

                            if (CheckInput(userChoiceString, new string[] { "c" }))
                            {
                                annualCost = GetAnnualCost();
                                amountPurchased = GetAmountPurchased();
                                cashBackPercent = GetCashBackPercent();

                                Corporate newMember = new Corporate(cashBackPercent, memberID, memberEmail, "Corporate", annualCost, amountPurchased);
                                membershipList.Add(newMember);
                                Console.WriteLine(newMember.ToString());
                                Console.WriteLine(" ");
                            } // end if Corporate
                        } // end if Create

                        // III. If option is 'List' 
                        else if (CheckInput(userChoiceString, new string[] { "L" }))
                        {
                            // A. For each membership in list
                            foreach (Membership member in membershipList)
                            {
                                // i. Write to console 
                                Console.WriteLine(member.ToString());
                            }
                            Console.WriteLine(" ");
                        } // end if List

                        // IV. If option is 'Update'
                        else if (CheckInput(userChoiceString, new string[] { "u" }))
                        {
                            string? userResponse;
                            // i. Prompt/get member ID from user
                            Console.WriteLine("Please enter member ID to update. ");
                            int memberIDEntered = Convert.ToInt32(Console.ReadLine());

                            // ii. Find member index if in list
                            int index = FindIndex(memberIDEntered, membershipList);

                            // While member ID is invalid
                            if (index == -1)
                            {
                                Console.WriteLine("Member ID not found. ");
                            }
                            else
                            {
                                // B. Prompt to update membership ID
                                Console.WriteLine("Press 'y' to update member ID. Any other key to continue. ");
                                userResponse = Console.ReadLine();
                                if ((userResponse == "y") || (userResponse == "Y"))
                                {
                                    Console.WriteLine("Please enter updated member ID. ");
                                    int memberIDUpdated = Convert.ToInt32(Console.ReadLine());
                                    membershipList[index].MemberID = memberIDUpdated;
                                }

                                // C. Prompt to update email address
                                Console.WriteLine("Press 'y' to update member email adress. Any other key to continue. ");
                                userResponse = Console.ReadLine();
                                if ((userResponse == "y") || (userResponse == "Y"))
                                {
                                    Console.WriteLine("Please enter updated member email address. ");
                                    string memberEmailUpdated = Console.ReadLine();
                                    membershipList[index].MemberEmail = memberEmailUpdated;
                                }

                                // D. Prompt to update annual cost
                                Console.WriteLine("Press 'y' to update member annual cost. Any other key to continue. ");
                                userResponse = Console.ReadLine();
                                if ((userResponse == "y") || (userResponse == "Y"))
                                {
                                    double annualCostUpdated = GetAnnualCost();
                                    membershipList[index].AnnualCost = annualCostUpdated;
                                }

                                // E. Prompt to update current amount purchased 
                                Console.WriteLine("Press 'y' to update current amount purchased. Any other key to continue. ");
                                userResponse = Console.ReadLine();
                                if ((userResponse == "y") || (userResponse == "Y"))
                                {
                                    double amountPurchasedUpdated = GetAmountPurchased();
                                    membershipList[index].AmountPurchased = amountPurchasedUpdated;
                                }

                                // F. Prompt to update cash back percent
                                Console.WriteLine("Press 'y' to update cash back percent Any other key to continue. ");
                                userResponse = Console.ReadLine();
                                if ((userResponse == "y") || (userResponse == "Y"))
                                {
                                    double cashBackPercentUpdated = GetCashBackPercent();
                                    membershipList[index].CashBackPercent = cashBackPercentUpdated;
                                }
                                Console.WriteLine("To change membership type, need to create new membership. ");
                                Console.WriteLine(" ");
                                Console.WriteLine(membershipList[index].ToString());
                                Console.WriteLine(" ");
                            }
                        } // end if Update

                        // V. If option is 'Delete'
                        else if (CheckInput(userChoiceString, new string[] { "d" }))
                        {
                            // i. Prompt/get member ID from user
                            Console.WriteLine("Please enter member ID to delete. ");
                            int memberIDEntered = Convert.ToInt32(Console.ReadLine());

                            // ii. Find member index if in list
                            int index = FindIndex(memberIDEntered, membershipList);
                            if (index == -1)
                            {
                                Console.WriteLine("Member ID not found. ");
                            }

                            // B. Delete from list 
                            else
                            {
                                Console.WriteLine("Press 'Y' to delete membership: " + membershipList[index].MemberID);
                                string? userInput = Console.ReadLine();
                                if ((userInput == "Y") || (userInput == "y"))
                                {
                                    membershipList.Remove(membershipList[index]);

                                    Console.WriteLine("Membership deleted. \n");
                                }
                            }
                            Console.WriteLine(" ");
                        } // end if delete

                    } // end do for administrative options
                      // While option is not 'Return'
                    while (!(userChoiceString == "B") && !(userChoiceString == "b"));
                } // end if for administrative options

                // iv. If option is 'Transaction' 
                if (CheckInput(userChoiceString, new string[] { "T" }))
                {
                    do
                    {
                        // a. Do
                        // I. Do 
                        do
                        {
                            // A. Provide user with menu options
                            Console.WriteLine("Please choose from the following transaction options. ");
                            Console.WriteLine("Press 'L' to list all memberships. ");
                            Console.WriteLine("Press 'P' to make a purchase transaction. ");
                            Console.WriteLine("Press 'R' to make a return transaction. ");
                            Console.WriteLine("Press 'A' to apply cashback. ");
                            Console.WriteLine("Press 'B' to go back to main menu. ");

                            // B. Get user option choice
                            userChoiceString = Console.ReadLine();

                            // C. Validate user option choice
                            if (!userChoice)
                            {
                                Console.WriteLine("Please enter a valid option.");
                            }
                            Console.WriteLine(" ");

                        } // end do for transaction options 
                          // While user choice is invalid 
                        while (!userChoice);

                        // II. If option is 'List' 
                        if (CheckInput(userChoiceString, new string[] { "L" }))
                        {
                            // A. Foreach membership in List
                            foreach (Membership member in membershipList)
                            {
                                // i. Write to console 
                                Console.WriteLine(member.ToString());
                            }
                            Console.WriteLine(" ");
                        } // end if List  

                        // III. If option is 'Purchase' 
                        else if (CheckInput(userChoiceString, new string[] { "P" }))
                        {
                            MakeTransaction(userChoiceString, membershipList);

                            Console.WriteLine(" ");

                        } // end if Purchase

                        // IV. If option is 'Return' 
                        else if (CheckInput(userChoiceString, new string[] { "R" }))
                        {
                            MakeTransaction(userChoiceString, membershipList);

                            Console.WriteLine(" ");

                        } // end if Return 

                        //  V. If option is 'Apply Cashback'
                        else if (CheckInput(userChoiceString, new string[] { "A" }))
                        {
                            // i. Prompt/get member ID from user
                            Console.WriteLine("Please enter member ID to apply cash back. ");
                            int memberIDEntered = Convert.ToInt32(Console.ReadLine());

                            // ii. Find member index if in list
                            int index = FindIndex(memberIDEntered, membershipList);
                            if (index == -1)
                            {
                                Console.WriteLine("Member ID not found. ");
                            }

                            // B. Apply for cashback 
                            else
                            {
                                membershipList[index].ApplyCashBack(memberIDEntered);
                            }
                            Console.WriteLine(" ");
                        } // end if Apply CashBack 

                    } // end do for transaction options
                      // While option is not 'Return'
                    while (!(userChoiceString == "B") && !(userChoiceString == "b"));
                } // end if for transaction options

            } // end main do for program 
              // B. While input is not quit
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

        static int FindIndex(int memberID, List<Membership> membershipList)
        {
            int index = -1;
            if (memberID == null)
            {
                Console.WriteLine("Please enter a valid account ID. ");
            }
            else
            {
                index = membershipList.FindIndex(member => member.MemberID == memberID);
            }

            return index;
        } // end FindIndex method

        static double GetAnnualCost()
        {
            double annualCost;
            do
            {
                Console.WriteLine("Please enter annual cost of membership. ");
                annualCost = Convert.ToDouble(Console.ReadLine());
                if (annualCost == null)
                {
                    Console.WriteLine("Please enter a valid annual cost. ");
                }
            } while (annualCost == null);
            return annualCost;
        }

        static double GetAmountPurchased()
        {
            double amountPurchased;
            do
            {
                Console.WriteLine("Please enter current amount purchased. ");
                amountPurchased = Convert.ToDouble(Console.ReadLine());
                if (amountPurchased == null)
                {
                    Console.WriteLine("Please enter a valid amount purchased. ");
                }
            } while (amountPurchased == null);
            return amountPurchased;
        }

        static double GetCashBackPercent()
        {
            double cashBackPercent;
            do
            {
                Console.WriteLine("Please enter cash back percent. ");
                cashBackPercent = Convert.ToDouble(Console.ReadLine());
                if (cashBackPercent == null)
                {
                    Console.WriteLine("Please enter a valid cash back amount. ");
                }
            } while (cashBackPercent == null);
            return cashBackPercent;
        }

        static void MakeTransaction(string userInput, List<Membership> membershipList)
        {
            int index;
            int memberID;
            double transactionAmount;

            do
            {
                // Prompt user for member ID
                Console.WriteLine("Please enter member ID. ");

                // Get member ID from user
                memberID = Convert.ToInt32(Console.ReadLine());

                // Find member index
                index = FindIndex(memberID, membershipList);
                if (index == -1)
                {
                    Console.WriteLine("Member ID not found. ");
                }
                // While member ID is invalid
            } while (index == -1);

            do
            {
                // a. Prompt user for transaction amount
                Console.WriteLine("Please enter transaction amount. ");

                // b. Get amount from user 
                transactionAmount = Convert.ToDouble(Console.ReadLine());

                if (transactionAmount <= 0)
                {
                    Console.WriteLine("Please enter a valid amount greater than zero. ");
                }

            } while (transactionAmount <= 0);

            if ((userInput == "P") || (userInput == "p"))
            {
                membershipList[index].Purchase(memberID, transactionAmount);
            }
            else if ((userInput == "R") || (userInput == "r"))
            {
                membershipList[index].Return(memberID, transactionAmount);
            }
        }

    } // end class
} // end namespace