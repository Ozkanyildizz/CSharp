using System;

namespace C_
{
    internal class DividedByZeroExceptionHandling
    {
        public void test()
        {
            try
            {
                // Kullanıcıdan sayı alma
                int numerator;
                bool converted = int.TryParse(Console.ReadLine(), out numerator);
                Console.WriteLine("Converted: " + converted);
                Console.WriteLine("Numerator: " + numerator);

                int denominator = int.Parse(Console.ReadLine());
                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);

                // NullReferenceException örneği
                string text = null;
                Console.WriteLine("Length of text: " + text.Length); // Burada NullReferenceException fırlatılır

                // IndexOutOfRangeException örneği
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("Fourth element: " + numbers[3]); // Dizide 3 eleman var, index 3 hatalı
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter integers only.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: Tried to use an object that is null.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Attempted to access an array element out of bounds.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }

        public void test2()
        {
            try
            {
                Divide(10, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace); // Hata ayıklama için faydalı
            }
        }

        static void Divide(int a, int b)
        {
            int result = a / b; // DivideByZeroException
        }

        public void InnerExceptionExample() // orjinal hatayı gösterrir 
        {
            try
            {
                try
                {
                    int[] arr = new int[3];
                    Console.WriteLine(arr[5]); // IndexOutOfRangeException
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new Exception("An error occurred while accessing the array.", ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer Exception Message: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception Message: " + ex.InnerException.Message);
                }
            }
        }
        public void HelpLinkTargetSiteExample()
        {
            try
            {
                int x = int.Parse("abc"); // FormatException
            }
            catch (Exception ex)
            {
                ex.HelpLink = "https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception";
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("TargetSite: " + ex.TargetSite);
                Console.WriteLine("HelpLink: " + ex.HelpLink);
            }

        }
    }
}
