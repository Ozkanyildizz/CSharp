using System;


namespace C_
{
    public class ExceptionFilters
    {
        public static void TestExceptionFilters()
        {
            try
            {
                Console.WriteLine("Enter a number to divide 100 by:");
                int denominator = 0;
                int result = 100 / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex) when (ex.Message.Contains("Sıfırla bölme"))
            {
                Console.WriteLine("Good morning! Division by zero is not allowed. Please try again.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero is not allowed. Please try again.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch when (DateTime.Now.DayOfWeek == DayOfWeek.Sunday) { Console.WriteLine("Hata sadece Pazar günü yakalanıyor!"); }
        }
    }
}
