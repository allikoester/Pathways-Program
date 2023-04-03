

namespace Membership
{
    class Program
    {
        static void Main(string[] args)
        {

            // I. Create list
            List<Membership> membershipList = new List<Membership>();

            Regular member1 = new Regular(3, 1234, "member1@gmail.com", "Regular", 60, 200);
            membershipList.Add(member1);
            Console.WriteLine(member1);
            member1.ApplyCashBack(1234);
            Console.WriteLine(" ");

            Executive member2 = new Executive(5, 2345, "member2@gmail.com", "Executive", 120, 500);
            membershipList.Add(member2);
            Console.WriteLine(member2);
            member2.ApplyCashBack(2345);
            Console.WriteLine(" ");

            Executive member3 = new Executive(5, 2346, "member3@gmail.com", "Executive", 120, 1500);
            membershipList.Add(member3);
            Console.WriteLine(member3);
            member3.ApplyCashBack(2346);
            Console.WriteLine(" ");

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
    } // end class
} // end namespace