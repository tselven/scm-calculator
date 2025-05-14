using System;
using System.Collections.Generic;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();
            List<string> studentGrades = new List<string>();

            Console.WriteLine("=== Welcome to the Grade Calculator ===");

            bool continueEntering = true;
            while (continueEntering)
            {
                Console.Write("\nEnter Student Name: ");
                string name = Console.ReadLine();

                int marks;
                Console.Write("Enter Marks (0 - 100): ");
                while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    Console.Write("Enter Marks (0 - 100): ");
                }

                string grade = CalculateGrade(marks);
                Console.WriteLine($"Student: {name}, Grade: {grade}");

                studentNames.Add(name);
                studentGrades.Add(grade);

                Console.Write("\nDo you want to enter another student? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "y")
                    continueEntering = false;
            }

            ShowSummaryReport(studentGrades, studentNames.Count);

            Console.WriteLine("\nThank you for using the Grade Calculator!");
            Console.ReadLine();
        }

        static string CalculateGrade(int marks)
        {
            if (marks > 75)
                return "A";
            else if (marks > 65)
                return "B";
            else if (marks > 55)
                return "C";
            else if (marks > 45)
                return "S";
            else
                return "F";
        }

        static void ShowSummaryReport(List<string> grades, int totalStudents)
        {
            Console.WriteLine("\n=== Summary Report ===");
            Console.WriteLine($"Total Students: {totalStudents}");

            var gradeCounts = new Dictionary<string, int>
            {
                {"A", 0},
                {"B", 0},
                {"C", 0},
                {"S", 0},
                {"F", 0}
            };

            foreach (var grade in grades)
            {
                if (gradeCounts.ContainsKey(grade))
                    gradeCounts[grade]++;
            }

            foreach (var grade in gradeCounts)
            {
                Console.WriteLine($"Grade {grade.Key}: {grade.Value}");
            }
        }
    }
}
