using System;
using System.Security.Cryptography.X509Certificates;


namespace Program
{
    internal class whileLoop
    {
        private int sum = 0;
        public void avarage()
        {

            int count = 0;
            Console.Write("Enter the number (-1 for exit): ");
            int num = int.Parse(Console.ReadLine());

            while (num != -1)
            {
                sum += num;
                count++;

                Console.Write("Enter the number (-1 for exit): ");
                num = int.Parse(Console.ReadLine());

                if (count != 0 )
                {
                   double average = (double)sum / count;
                    Console.WriteLine($"The total of the {count} grades entered is: {sum}");
                    Console.WriteLine($"The average is: {average:F}");

                }
                else
                {
                   
                    Console.WriteLine("No grades were entered.");

                }
               

            }
           
        }
        
        public void analysis()
        {
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;
            while (studentCounter <= 10)
            {
                Console.Write("Enter result (1-2): ");
                int result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    studentCounter++;
                    passes++;
                }
                else if (result == 2)
                {    studentCounter++;
                    failures++; 
                }
                else
                    Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
            Console.WriteLine($"Passed: {passes}\nFailed: {failures}");
            if (passes > 8)
                Console.WriteLine("Bonus to instructor!");
        }

        
    }
}
