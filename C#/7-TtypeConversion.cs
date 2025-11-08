using System;

namespace Program
{
    class TypeConversion
    {
        public void typeConversion()
        {
         


            decimal principal = 1000;

            double rate = 0.05;

 
            Console.WriteLine("Year\tAmount on deposit");

            // Calculate compound interest for 10 years
            for (int year = 1; year <= 10; year++)
            {
                // Math.Pow returns double, so we cast it to decimal for compatibility
                decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));

                // Display the year and the formatted amount (currency format)
                Console.WriteLine("{0}\t{1:C}", year, amount);
            }

            Console.WriteLine("\n--- Type Conversion Examples ---\n");

            // -------------------------------
            // Implicit Conversion (safe, automatic)
            // -------------------------------

            int intVal = 42;
            double doubleVal = intVal; // int → double (no data loss)
            Console.WriteLine("Implicit conversion (int → double): " + doubleVal);

            // -------------------------------
            // Explicit Conversion (manual, may lose data)
            // -------------------------------

            double originalDouble = 9.7;
            int castedInt = (int)originalDouble; // double → int (fraction is truncated)
            Console.WriteLine("Explicit conversion (double → int): " + castedInt);

            // -------------------------------
            // Convert class (safe conversion between types)
            // -------------------------------

            // Convert.ToInt32 converts a string to an integer.
            // It throws an exception if the string is not a valid number.
            string strNumber = "123";
            int parsedInt = Convert.ToInt32(strNumber); // string → int
            Console.WriteLine("Convert string to int: " + parsedInt);

            // -------------------------------
            // Parse method (direct string-to-int conversion)
            // -------------------------------

            // int.Parse also converts a string to an integer.
            // Like Convert, it throws an exception if the string is invalid.
            string strValue = "456";
            int parsedValue = int.Parse(strValue); // string → int
            Console.WriteLine("Parse string to int: " + parsedValue);

            // -------------------------------
            // TryParse method (safe parsing with error handling)
            // -------------------------------

            // TryParse attempts to convert a string to an integer.
            // It returns true if successful, false if not.
            // The result is stored in the 'result' variable only if parsing succeeds.
            string input = "789";
            bool success = int.TryParse(input, out int result);

            if (success)
            {
                Console.WriteLine("TryParse succeeded: " + result);
            }
            else
            {
                Console.WriteLine("TryParse failed.");
            }


            // -------------------------------
            // Decimal vs Double Conversion
            // -------------------------------

            double doubleRate = 0.075;
            decimal decimalRate = (decimal)doubleRate; // explicit cast required
            Console.WriteLine("Double to Decimal conversion: " + decimalRate);

            // Note: decimal is more precise for financial calculations, but slower than double
        }
    }
}