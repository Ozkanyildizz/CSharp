using System;


namespace Program
{
    class GradeBook
    {
        public void gradeBook() 
        {
            int[] gradeBookArray = { 87, 78, 68, 100, 100, 65, 76, 89, 90, 34 };
            int total = 0;
            int highest = 0;
            int lowest = 100;
           
            Console.WriteLine("The Grades are: ");
            for (int i = 0; i < gradeBookArray.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} {gradeBookArray[i],4}");
                total = total + gradeBookArray[i];

                if (gradeBookArray[i] < lowest  ) lowest = gradeBookArray[i];
                if (gradeBookArray[i] > highest ) highest = gradeBookArray[i];

            }
            Console.WriteLine($"Class avarage is : {total / gradeBookArray.Length}\nLowest grade is {lowest}\nHighest grade is {highest}\n");
        }
    }
}
