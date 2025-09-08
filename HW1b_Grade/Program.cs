// HW1b Grade

// Your Name: Peyton TUrney
// Did you seek help ? If yes, specify the helper or web link here: No outside help. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // What I need: fname, lname, studentID, %grade for: hw, part, quiz, exam1, exam2, exam3

            double hw;
            double participation;
            double quiz;
            double exam1;
            double exam2;
            double exam3;

            double partquizsum;
            double sum;

            string hwString;
            string partString;
            string quizString;
            string exam1String;
            string exam2String;
            string exam3String;

            string firstname;
            string lastname;
            string studentID;

            Console.WriteLine("Please input your first name");
            firstname = Console.ReadLine();
            Console.WriteLine("Please input your last name");
            lastname = Console.ReadLine();
            Console.WriteLine("Please input your Student ID number");
            studentID = Console.ReadLine();

            Console.WriteLine("What is your overall % grade for homework assignments?");
            hwString = Console.ReadLine();
            Console.WriteLine("What is your overall % grade for participation?");
            partString = Console.ReadLine();
            Console.WriteLine("What is your overall % grade for quizzes?");
            quizString = Console.ReadLine();
            Console.WriteLine("What is your overall % grade for Exam 1?");
            exam1String = Console.ReadLine();
            Console.WriteLine("What is your overall % grade for Exam 2?");
            exam2String = Console.ReadLine();
            Console.WriteLine("What is your overall % grade for Exam 3?");
            exam3String = Console.ReadLine();

            hw = Convert.ToDouble(hwString);
            participation = Convert.ToDouble(partString);
            quiz = Convert.ToDouble(quizString);
            exam1 = Convert.ToDouble(exam1String);
            exam2 = Convert.ToDouble(exam2String);
            exam3 = Convert.ToDouble(exam3String);

            partquizsum = participation + quiz; // unsure how quizzes fit into participation, I believe just adding
            sum = (hw * 0.2) + (partquizsum * 0.15) + (exam1 * 0.15) + (exam2 * 0.25) + (exam3 * 0.25);

            Console.WriteLine($"{firstname} {lastname} ({studentID}), your final grade is {sum.ToString("F2")}");

        }
    }
}
