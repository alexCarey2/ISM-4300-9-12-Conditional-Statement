using System;

namespace ISM_4300_Conditional_Statement_9_12
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);
                string letterGrade = grade.ToString();

                if (grade < 60)
                {
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

                if (grade >= 72)
                {
                    Console.WriteLine("Congrats, you passed!");
                }
                else if (grade < 71)
                {
                    Console.WriteLine("Sorry, you failed");
                }
            }


            catch
            {
                Console.WriteLine("there is an error"); 
            }
        }
    }
}
