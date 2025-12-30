using System;

public class NegativeNumberException : Exception
{
    // Varsayılan constructor
    public NegativeNumberException()
        : base("Illegal operation for a negative number")
    {
    }

    // Özel mesajlı constructor
    public NegativeNumberException(string messageValue)
        : base(messageValue)
    {
    }

    // InnerException ile birlikte constructor
    public NegativeNumberException(string messageValue, Exception inner)
        : base(messageValue, inner)
    {
    }
}


class SquareRootTest
{
    public static void test()
    {
        bool continueLoop = true;

        do
        {
            try
            {
                Console.Write("Enter a value to calculate the square root of: ");
                double inputValue = double.Parse(Console.ReadLine());
                double result = SquareRoot(inputValue);

                Console.WriteLine($"The square root of {inputValue} is {result:F6}");
                continueLoop = false;
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Please enter a double value.\n");
            }
            catch (NegativeNumberException negativeNumberException)
            {
                Console.WriteLine("\n" + negativeNumberException.Message);
                Console.WriteLine("Please enter a non-negative value.\n");
            }
        } while (continueLoop);
    }

    // Negatif sayı kontrolü yapan metot
    public static double SquareRoot(double value)
    {
        if (value < 0)
        {
            throw new NegativeNumberException("Square root of negative number not permitted.");
        }
        else
        {
            return Math.Sqrt(value);
        }
    }
}
