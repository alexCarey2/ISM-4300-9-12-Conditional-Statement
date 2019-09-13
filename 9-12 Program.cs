using System;

namespace ISM_4300_Conditional_Statement_9_12
{
    class Program
    {
        static void Main(string[] args)

        {
            //Ask user for expected percentage in the class
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                // Read & convert user input from int to string 
                string input = Console.ReadLine();
                int grade = int.Parse(input);
                string letterGrade = grade.ToString();

                //Conditions for grade increments
                if (grade < 60)
                {
                    //Convert grade to letter associated with syllabus
                    letterGrade = ("F");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 61 )
                {
                    letterGrade = ("D-");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 67)
                {
                    letterGrade = ("D");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 69)
                {
                    letterGrade = ("D+");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 71)
                {
                    letterGrade = ("C-");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 77)
                {
                    letterGrade = ("C");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 79)
                {
                    letterGrade = ("C+");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 81)
                {
                    letterGrade = ("B-");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 87)
                {
                    letterGrade = ("B");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 89)
                {
                    letterGrade = ("B+");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 91)
                {
                    letterGrade = ("A-");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade <= 97)
                {
                    letterGrade = ("A");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                else if (grade > 100)
                {
                    letterGrade = ("A+");
                    Console.WriteLine("Your letter grade in the course is: " + letterGrade);
                }
                //Display success text if grade is greater than 72
                if (grade >= 72)
                {
                    Console.WriteLine("Congrats, you passed!");
                }
                //Display failure text is grade is less than 71
                else if (grade < 71)
                {
                    Console.WriteLine("Sorry, you failed");
                }
            }

            //catch if user does not enter proper value 
            catch
            {
                Console.WriteLine("there is an error"); 
            }
        }
    }
}
