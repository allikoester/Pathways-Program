
// using Membership;

// namespace MakeTransaction
// {
//     class Transaction
//     {

//         static void MakeTransaction(TransactionType transactionType, List<Membership> membershipList)
//         {
//             int index;
//             int memberID;
//             double transactionAmount;

//             do
//             {
//                 // Prompt user for member ID
//                 Console.WriteLine("Please enter member ID. ");

//                 // Get member ID from user
//                 memberID = Convert.ToInt32(Console.ReadLine());

//                 // Find member index
//                 index = FindIndex(memberID, membershipList);
//                 if (index == -1)
//                 {
//                     Console.WriteLine("Member ID not found. ");
//                 }
//                 // While member ID is invalid
//             } while (index == -1);

//             do
//             {
//                 // a. Prompt user for transaction amount
//                 Console.WriteLine("Please enter transaction amount. ");

//                 // b. Get amount from user 
//                 transactionAmount = Convert.ToDouble(Console.ReadLine());

//                 if (transactionAmount <= 0)
//                 {
//                     Console.WriteLine("Please enter a valid amount greater than zero. ");
//                 }

//             } while (transactionAmount <= 0);

//             if (transactionType == TransactionType.Purchase)
//             {
//                 membershipList[index].Purchase(memberID, transactionAmount);
//             }
//             else if (transactionType == TransactionType.Return)
//             {
//                 membershipList[index].Return(memberID, transactionAmount);
//             }
//         }


//     } // end class 
// } // end namespace 