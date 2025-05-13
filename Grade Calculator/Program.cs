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
            int marks = Convert.ToInt32(Console.ReadLine());

            string grade = "F";
            if (marks > 75)
                grade = "A";
            else if (marks > 65)
                grade = "B";
            else if (marks > 55)
                grade = "C";
            else if (marks > 45)
                grade = "S";

            Console.WriteLine("Student: " + name + ", Grade: " + grade);
            Console.ReadLine();
        }
    }
}
