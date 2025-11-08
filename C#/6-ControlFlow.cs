
using System;


namespace Program
{
    class ControlFlow
    {


        public void forLoop()
        {
            decimal principal = 1000; // initial amount before interest
            double rate = 0.05;       // interest rate

            // display headers
            Console.WriteLine("Year\tAmount on deposit");

            // calculate amount on deposit for each of ten years
            for (int year = 1; year <= 10; year++)
            {
                // calculate new amount for specified year
                decimal amount = principal *
                    ((decimal)Math.Pow(1.0 + rate, year));

                // display the year and the amount
                Console.WriteLine("{0}\t{1:C}", year, amount);
            }
        }

        public void doWhileLoop()
        {
            int sum = 0;
            int number;
            do
            {
                Console.Write("Enter a number (0 to end): ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            } while (number != 0);
            Console.WriteLine("The sum is: " + sum);
        }
    }

}


namespace switchCase {

    class LetterGrades
    {
        // Grade counters
        static int aCount = 0;
        static int bCount = 0;
        static int cCount = 0;
        static int dCount = 0;
        static int fCount = 0;

        public void lettergrade()
        {
            int total = 0;
            int gradeCounter = 0;

            Console.Write("Enter the integer grades in the range 0–100 q for break: ");

            string input = Console.ReadLine();

            while (input != "q")
            {
                int grade = int.Parse(input);
                total += grade;
                ++gradeCounter;

                // Call the switch-case function
                EvaluateGrade(grade);
                Console.Write("Type the grade q for break: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("\nGrade Report:");

            if (gradeCounter != 0)
            {
                double average = (double)total / gradeCounter;

                Console.WriteLine("Total of the {0} grades entered is {1}", gradeCounter, total);
                Console.WriteLine("Class average is {0:F}", average);
                Console.WriteLine("Number of students who received each grade:");
                Console.WriteLine("A: {0}", aCount);
                Console.WriteLine("B: {0}", bCount);
                Console.WriteLine("C: {0}", cCount);
                Console.WriteLine("D: {0}", dCount);
                Console.WriteLine("F: {0}", fCount);
            }
            else
            {
                Console.WriteLine("No grades were entered");
            }
        }

        // Switch-case function to evaluate grade
        public static void EvaluateGrade(int grade)
        {
            switch (grade / 10)
            {
                case 10:
                case 9:
                    ++aCount;
                    break;
                case 8:
                    ++bCount;
                    break;
                case 7:
                    ++cCount;
                    break;
                case 6:
                    ++dCount;
                    break;
                default:
                    ++fCount;
                    break;
            }
        }
    }
}
