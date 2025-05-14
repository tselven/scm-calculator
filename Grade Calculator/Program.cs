using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks (out of 100): ");
            int marks;
            while (!int.TryParse(Console.ReadLine(), out marks))
            {
                Console.WriteLine("Invalid input. Please enter only numbers.");
                Console.Write("Enter marks: ");
            }



            string grade = "F";
            if (marks > 75)
                grade = "A";
            else if (marks > 65)
                grade = "B";
            else if (marks > 55)
                grade = "C";
            else if (marks > 45)
                grade = "S";
            else if (marks <= 45)
                grade = "F";

                Console.WriteLine("Student: " + name + ", Grade: " + grade);
            Console.ReadLine();

            bool IsNumeric(string value)
            {
                foreach (char c in value)
                {
                    if (!char.IsDigit(c)) return false;
                }
                return !string.IsNullOrWhiteSpace(value);
            }
        }
    }
}
