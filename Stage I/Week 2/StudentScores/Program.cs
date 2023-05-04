/* 

Developer Name: Alli Koester
Last Update: 3/14/23

Program Description: Program uses a two-dimensional array to store multiple students' grades to obtain 
    the average score for each student, 
    and the minimum, maximum, and average for the class. 

Requirements: 
(1). Numbers will be integers

Algorithm: 
    I. Define array for student scores
    II. For each student 
        i. Initialize key variables 
        ii. For each grade for each student 
            a. Add up score to find sum 
        ii. Calculate student average by sum / length
        iii. Output student average score
        iv. If student average less than minimum, make minimum student average
        v. If student average greater than maximum student average
        vi.  Total sum of scores by adding all student averages
    III. Find total average score by total sum of scores/ number of students 

*/

using System;
namespace Studentscores
{

    class Program
    {
        public static void Main(string[] args)
        {
            // I. Define array for student scores
            int[,] scores =
            {
            {88, 89, 85, 89},
            {90, 97, 97, 98},
            {67, 65, 68, 67},
            {77, 76, 78, 79}
            };

            int minimum = 100;
            int maximum = 0;
            int totalAverage = 0;
            int classAverage;
            int N = scores.GetLength(0);

            // II. For each student 
            for (int student = 0; student < scores.GetLength(0); student++)
            {
                int studentSum = 0;
                int studentAverage;


                // i.Add up each score to find sum
                for (int grade = 0; grade < scores.GetLength(0); grade++)
                {
                    studentSum += scores[student, grade];
                }
                // ii.Calculate student average by sum / length
                studentAverage = studentSum / N;

                // iii.Output student average score
                Console.WriteLine($"Student's' average score is: {studentAverage}");

                // iv.Find minimum student average

                if (studentAverage <= minimum)
                {
                    minimum = studentAverage;
                }

                // v.Find maximum student average
                if (studentAverage >= maximum)
                {
                    maximum = studentAverage;
                }

                // Vi.Find total sum of average scores by adding all student averages
                totalAverage += studentAverage;

            }
            Console.WriteLine("The minimum average is: " + minimum);
            Console.WriteLine("The maximum average is: " + maximum);

            // III.Find total average score by total sum of scores / number of students
            classAverage = totalAverage / N;
            Console.WriteLine("The class average is: " + classAverage);
        }
    }
}