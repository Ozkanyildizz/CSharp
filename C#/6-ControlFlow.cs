
using System;

namespace controlFlow
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
    }

}

