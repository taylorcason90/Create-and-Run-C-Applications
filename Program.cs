using System;

namespace StudentGrading
{
    class Program
    {
        static void Main()
        {
            // Student names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            // Original individual scores
            int[] sophiaScores = { 90, 86, 87, 98, 100 };
            int[] andrewScores = { 92, 89, 81, 96, 90 };
            int[] emmaScores = { 90, 85, 87, 98, 68 };
            int[] loganScores = { 90, 95, 87, 88, 96 };

            // Write the Report Header to the console
            Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

            // Iterate over each student name
            foreach (string name in studentNames)
            {
                int[] currentScores;

                // Set currentScores based on the student name
                switch (name)
                {
                    case "Sophia":
                        currentScores = sophiaScores;
                        break;
                    case "Andrew":
                        currentScores = andrewScores;
                        break;
                    case "Emma":
                        currentScores = emmaScores;
                        break;
                    case "Logan":
                        currentScores = loganScores;
                        break;
                    default:
                        currentScores = new int[0]; // Default to empty array if name not found
                        break;
                }

                // Sum the exam scores and count extra credit
                double sum = 0;
                int examCount = 0;

                foreach (int score in currentScores)
                {
                    // Check if the score is an extra credit assignment (value <= 10)
                    if (score <= 10)
                    {
                        sum += score * 0.1; // Extra credit contributes 10%
                    }
                    else
                    {
                        sum += score;
                        examCount++;
                    }
                }

                // Calculate the average score
                double average = sum / examCount;

                // Calculate extra credit points
                int extraCreditPoints = 0;
                foreach (int score in currentScores)
                {
                    if (score <= 10)
                    {
                        extraCreditPoints += score;
                    }
                }

                // Display the student's name, exam score, overall grade, and extra credit
                Console.WriteLine($"{name}\t\t{average:F1}\t\t{average + extraCreditPoints / 100:F2}\t\t{GetLetterGrade(average)}\t\t{extraCreditPoints} ({extraCreditPoints / 100.0:F2} pts)");
            }

            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();
        }

        static string GetLetterGrade(double average)
        {
            if (average >= 97)
                return "A+";
            else if (average >= 93)
                return "A";
            else if (average >= 90)
                return "A-";
            else if (average >= 87)
                return "B+";
            else if (average >= 83)
                return "B";
            else if (average >= 80)
                return "B-";
            else if (average >= 77)
                return "C+";
            else if (average >= 73)
                return "C";
            else if (average >= 70)
                return "C-";
            else if (average >= 67)
                return "D+";
            else if (average >= 63)
                return "D";
            else if (average >= 60)
                return "D-";
            else
                return "F";
        }
    }
}
