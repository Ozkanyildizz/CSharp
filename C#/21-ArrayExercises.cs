using System;

class GradeBookExercise
{
    private int[,] grades; // rectangular array of student grades

    // auto-implemented property CourseName
    public string CourseName { get; set; }

    // constructor
    public GradeBookExercise(string name, int[,] gradesArray)
    {
        CourseName = name;
        grades = gradesArray;
    }

    // display welcome message
    public void DisplayMessage()
    {
        Console.WriteLine($"Welcome to the grade book for\n{CourseName}!\n");
    }

    // process grades
    public void ProcessGrades()
    {
        OutputGrades();

        Console.WriteLine(
            $"\nLowest grade in the grade book is {GetMinimum()}" +
            $"\nHighest grade in the grade book is {GetMaximum()}\n");

        OutputBarChart();
    }

    // find minimum grade
    public int GetMinimum()
    {
        var lowGrade = grades[0, 0];

        foreach (var grade in grades)
        {
            if (grade < lowGrade)
            {
                lowGrade = grade;
            }
        }

        return lowGrade;
    }

    // find maximum grade
    public int GetMaximum()
    {
        var highGrade = grades[0, 0];

        foreach (var grade in grades)
        {
            if (grade > highGrade)
            {
                highGrade = grade;
            }
        }

        return highGrade;
    }

    // calculate average for a student
    public double GetAverage(int student)
    {
        var gradeCount = grades.GetLength(1);
        var total = 0.0;

        for (var exam = 0; exam < gradeCount; ++exam)
        {
            total += grades[student, exam];
        }

        return total / gradeCount;
    }

    // output bar chart of grade distribution
    public void OutputBarChart()
    {
        Console.WriteLine("Overall grade distribution:");

        var frequency = new int[11];

        foreach (var grade in grades)
        {
            ++frequency[grade / 10];
        }

        for (var count = 0; count < frequency.Length; ++count)
        {
            if (count == 10)
            {
                Console.Write("  100: ");
            }
            else
            {
                Console.Write($"{count * 10:D2}-{count * 10 + 9:D2}: ");
            }

            for (var stars = 0; stars < frequency[count]; ++stars)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    // output grades and averages
    public void OutputGrades()
    {
        Console.WriteLine("The grades are:\n");
        Console.Write("            ");

        for (var test = 0; test < grades.GetLength(1); ++test)
        {
            Console.Write($"Test {test + 1} ");
        }

        Console.WriteLine("Average");

        for (var student = 0; student < grades.GetLength(0); ++student)
        {
            Console.Write($"Student {student + 1,2}");

            for (var grade = 0; grade < grades.GetLength(1); ++grade)
            {
                Console.Write($"{grades[student, grade],8}");
            }

            Console.WriteLine($"{GetAverage(student),9:F}");
        }
    }
    public static void Test()
    {
        int[,] gradesArray = {
            { 87, 96, 70 },
            { 68, 87, 90 },
            { 94, 100, 90 },
            { 100, 81, 82 },
            { 83, 65, 85 },
            { 78, 87, 65 },
            { 85, 75, 83 },
            { 91, 94, 100 },
            { 76, 72, 84 },
            { 87, 93, 73 }
        };

        var myGradeBook = new GradeBookExercise("CS101 Introduction to C#", gradesArray);
        myGradeBook.DisplayMessage();
        myGradeBook.ProcessGrades();
    }
}
