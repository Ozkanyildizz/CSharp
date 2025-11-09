using System;


namespace Program
{
    internal class RecursiveFactorialTest
    {
        public static void Factorial()
        {
            for (long i = 0; i <= 20; i++)
            {
                Console.WriteLine($"Factorial of {i} is {CalculateFactorial(i)}");
            }

        }
        public static long  CalculateFactorial(long x)
        {
            if (x <= 0)
            {
                return 1;

            }
            else
            {
                return x * CalculateFactorial(x - 1);
            }
        }
    }
}
