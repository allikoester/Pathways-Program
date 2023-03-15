/*

Developer Name: Alli Koester
Last Upate: 3/10/23

Program Description: Program will allow user to calculate individual student grades for class, by obtaining number of students, student names, 
    5 homework grades, 3 quiz grades, and 2 exam grades. Program will calculate average homework grade, average quiz grade, and average exam
    grade. Program will then calculate final grade by adding 50% homework average, 30% quiz average, and 20% exam average, and assign a letter 
    grade. Program will provide user with student's name, homework average, quiz average, exam averge, final average, and final grade. 

Requirements:
    (1) The input will come from user via console, and the output will be to the user
    (2) The student name will be a string
    (3) The grades will be integers from 0 to 100 inclusively
    (4) The averages and final grade will be doubles from 0 to 100 inclusively

Algorithm: 
    I. Prompt user for number of students
    II. Get number of students from the user
    III. For number of students
        
            a. Prompt user for student name
            b. Get student name from user
            c. For 5 times
                i. Prompt user for homework grade
                ii. Get homework grade from user
                iii. If number is invalid (<1 or >100)
                    Provide error message
                iv. Add homework grades together to calculate total homework number
                v. Obtain average homework grade by taking total homework / 5
            d. For 3 times
                i. Prompt user for quiz grade
                ii. Get quiz grade from user
                iii. If number is invalid (<1 or >100)
                    Provide error message
                iv. Add quiz grades together to calculate total quiz number
                v. Obtain average quiz grade by taking total quiz / 3
            e. For 2 times
                i. Prompt user for exam grade
                ii. Get exam grade from user
                iii. If number is invalid (<1 or >100)
                    Provide error message
                iv. Add exam grades together to calculate total exam number
                v. Obtain average exam grade by taking total exam / 2
     
            f. Calculate final grade by adding 0.5 * average homework + 0.3 * average quiz + 0.2 * average exam
            g. Calculate student's final letter grade 
                a. If >= 90, assign letter grade A
                b. Else if >= 80, assign letter grade B
                c. Else if >= 70, assign letter grade C
                d. Else if >= 60, assign letter grade D
                e. Else >= 50, assign letter grade F
            h. Provide student name, average homework, average quiz, average exam, final grade, and letter grade 
*/

namespace StudentGrades
{
    class Program
    {
        static int GetAValidInteger(string prompt, int lowNumber, int? highNumber = 100)
        {
            int x = 0;

            // II. Do
            do
            {
                // a.  Prompt the user for the number
                Console.Write(prompt);
                // b.  Get the number from the user
                x = Convert.ToInt32(Console.ReadLine());
                // c.  If the number is invalid (<1 or >100)
                if (highNumber == null)
                {
                    if (x < lowNumber)
                    {
                        Console.WriteLine($"Please enter a number greater than {lowNumber}");
                        continue;
                    }
                }

                if ((x < lowNumber) || (x > highNumber))
                {
                    // i.  Provide error message
                    Console.WriteLine($"Please enter a number between {lowNumber} and {highNumber}. ");
                }

            } // end do  
            while (x < lowNumber || x > highNumber);

            // Return value 
            return x;


        } // end of Method
        static void Main(string[] args)
        {
            int numberStudents;


            // I. Prompt user for number of students
            // II. Get number of students from the user
            numberStudents = GetAValidInteger("Please enter number of students: ", 1, null);

            // III. For number of students
            for (int i = 0; i < numberStudents; i++)
            {
                string studentName;
                int homeworkGrade = 0;
                int totalHomeworkGrade = 0;
                int averageHomeworkGrade = 0;
                int quizGrade = 0;
                int totalQuizGrade = 0;
                int averageQuizGrade = 0;
                int examGrade = 0;
                int totalExamGrade = 0;
                int averageExamGrade = 0;
                double finalGrade = 0;
                char letterGrade;

                // a. Prompt user for student name
                Console.Write("Please enter student name: ");

                // b. Get student name from user
                studentName = Console.ReadLine();

                // c. For 5 times
                // i. Prompt user for homework grade
                // ii. Get homework grade from user
                // iii. If number is invalid (<1 or >100)
                // Provide error message
                // iv. Add homework grades together to calculate total homework number
                // v. Obtain average homework grade by taking total homework / 5
                for (int j = 0; j < 5; j++)
                {
                    homeworkGrade = GetAValidInteger("Please enter a homework grade " + (j + 1) + " : ", 0);
                    totalHomeworkGrade = homeworkGrade + totalHomeworkGrade;
                }
                averageHomeworkGrade = totalHomeworkGrade / 5;

                // g. Prompt user for quiz grades (3)
                // h. Get quiz grades from user
                // i. If number is invalid (<1 or >100)
                // i. Provide error message
                for (int k = 0; k < 3; k++)
                {
                    quizGrade = GetAValidInteger("Please enter a quiz grade: ", 0);
                    totalQuizGrade = quizGrade + totalQuizGrade;
                }
                averageQuizGrade = totalQuizGrade / 3;

                // j. Prompt user for exam grades (2)
                // k. Get exam grades from user
                // l. If number is invalid (<1 or >100)
                // i. Provide error message
                for (int l = 0; l < 2; l++)
                {
                    examGrade = GetAValidInteger("Please enter an exam grade: ", 0);
                    totalExamGrade = examGrade + totalExamGrade;
                }
                averageExamGrade = totalExamGrade / 2;

                // C. Calculate final grade by adding 0.5 * average homework + 0.3 * average quiz + 0.2 * average exam
                finalGrade = (0.5 * averageHomeworkGrade) + (0.3 * averageQuizGrade) + (0.2 * averageExamGrade);

                // D.  Calculate student's final letter grade 
                // a. If >= 90, assign letter grade A
                if (finalGrade >= 90)
                {
                    letterGrade = 'A';
                }
                // b. Else if >= 80, assign letter grade B
                else if (finalGrade >= 80)
                {
                    letterGrade = 'B';
                }
                // c. Else if >= 70, assign letter grade C
                else if (finalGrade >= 70)
                {
                    letterGrade = 'C';
                }
                // d. Else if >= 60, assign letter grade D
                else if (finalGrade >= 60)
                {
                    letterGrade = 'D';
                }
                // e. Else assign letter grade F
                else
                {
                    letterGrade = 'F';
                }

                // E. Provide student name, average homework, average quiz, average exam, final grade, and letter grade 
                Console.WriteLine($"{studentName}'s grades: Average homework grade is: {averageHomeworkGrade}, Average quiz grade is: {averageQuizGrade}, Average exam grade is: {averageExamGrade}, Final average grade is: {finalGrade}, and Letter grade is: {letterGrade}");

            } // end for 
        } // end Main
    } // end Program 
} // end Namespace
