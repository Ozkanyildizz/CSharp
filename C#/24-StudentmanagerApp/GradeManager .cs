/*
--- Student Report Table ---
Student Name       Exam 1    Exam 2     AverageGrade letter
-----------------------------------------------------------
özkan                  56       100       78,00      B ****
yıldız                 78        56       67,00       C ***
-----------------------------------------------------------
Sınav Ort.          67,00     78,00

Maximum grade: 100
Minimum grade:  56
             */
using System;
namespace StudentmanagerApp
{
    internal class GradeManager
    {
        Student[] students;
        private int[,] studentGrades;

        public GradeManager(int studentCount, int examCount)
        {
            students = new Student[studentCount];
            studentGrades = new int[studentCount, examCount];
            for (int i = 0; i < studentCount; i++)
            {
                for (int j = 0; j < examCount; j++)
                {
                    studentGrades[i, j] = 0;
                }
            }
        }

        public void InputGrades()
        {
            Console.WriteLine("Enter student names and their grades:");

            for (int i = 0; i < students.Length; i++) 
            {
                string name = "";
                bool nameEntered = false;

               
                while (!nameEntered)
                {
                    Console.Write($"Enter name for student {i + 1}: ");
                    name = Console.ReadLine();

             
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        
                        students[i] = new Student(name);
                        nameEntered = true; 
                    }
                    else
                    {
                
                        Console.WriteLine("Student name cannot be empty. Please enter a valid name.");
                    }
                }


                for (int j = 0; j < studentGrades.GetLength(1); j++)
                {
                    bool validInput = false;
                    while (!validInput) 
                    {
                        try
                        {
                            Console.Write($"Enter grade {j + 1} for student {students[i].Name}: ");

                            int gradeValue = int.Parse(Console.ReadLine());

                            if (gradeValue >= 0 && gradeValue <= 100)
                            {
                                studentGrades[i, j] = gradeValue;
                                validInput = true; 
                            }
                            else
                            {
                       
                                Console.WriteLine("Grade must be between 0 and 100.");
                            }
                        }
                        catch (FormatException ex)
                        {
                            
                            Console.WriteLine($"Error: Invalid input. Please enter a whole number for the grade. ({ex.Message})");
                        }
                        
                    }
                }
            }
        }

        private double CalculateStudentAverage(int studentIndex)
        {
            int total = 0;

            for (int i = 0; i < studentGrades.GetLength(1); ++i) 
            {
                total = total + studentGrades[studentIndex, i];
            }
            return (double) total / studentGrades.GetLength(1);
        }
        public double CalculateExamAverage(int examIndex)
        {
            int total = 0;
            for (int i = 0; i < studentGrades.GetLength(0); i++)
            {
                total = total + studentGrades[i,examIndex];
            }
            return (double)total/studentGrades.GetLength(0);
        }

        public void MaxMinGrade(out int maxGrade, out int MinGrade)
        {
            maxGrade = studentGrades[0, 0];
            MinGrade = studentGrades[0, 0];
            foreach (int grade in studentGrades)
            {
                if (grade > maxGrade)
                {
                    maxGrade = grade;
                }
                if (grade < MinGrade)
                {
                    MinGrade = grade;
                }
            }
        }

        public string GetLetterGrade(double average)
        {
            string letterGrade; 


            switch ((int)average / 10)
            {
                case 10: // 100
                case 9:  // 90-99
                    letterGrade = "A *****";
                    break;
                case 8:  // 80-89
                case 7:  // 70-79
                    letterGrade = "B ****";
                    break;
                case 6:  // 60-69
                    letterGrade = "C ***";
                    break;
                case 5:  // 50-59
                    letterGrade = "D **";
                    break;
                default: // 0-49  (4, 3, 2, 1, 0)
                    letterGrade = "F *";
                    break;
            }
            return letterGrade;
        }

        public void DisplayReport()
        {
            Console.WriteLine("\n--- Student Report Table ---");

            int examCount = studentGrades.GetLength(1);
 
            // 15 (name) + (exam count * 10) + 12 (avrg) + 12 letter grade)
            int totalWidth = 15 + (examCount * 10) + 12 + 12;

           
            Console.Write($"{"Student Name",-15}"); 

            for (int j = 0; j < examCount; j++)
            {
                Console.Write($"{"Exam " + (j + 1),10}"); 
            }

            Console.Write($"{"Average",12}"); 
            Console.WriteLine($"{"Grade letter",12}"); 

            
            Console.WriteLine(new string('-', totalWidth));

         
            for (int i = 0; i < students.Length; i++)
            {
               
                Console.Write($"{students[i].Name,-15}");

           
                for (int j = 0; j < examCount; j++)
                {
                    Console.Write($"{studentGrades[i, j],10}");
                }

             
                double avg = CalculateStudentAverage(i);
                Console.Write($"{avg,12:F2}"); 


                string letterGrade = GetLetterGrade(avg);
                Console.WriteLine($"{letterGrade,12}");
            }

            Console.WriteLine(new string('-', totalWidth));

        
            Console.Write($"{"Sınav Ort.",-15}"); 
            for (int j = 0; j < examCount; j++)
            {
                double examAvg = CalculateExamAverage(j);
                Console.Write($"{examAvg,10:F2}"); 
            }
            Console.WriteLine();

     
            int maxGrade, minGrade;
            MaxMinGrade(out maxGrade, out minGrade);
            Console.WriteLine($"\nMaximum grade: {maxGrade}");
            Console.WriteLine($"Minimum grade:  {minGrade}");
        }

    }
}
