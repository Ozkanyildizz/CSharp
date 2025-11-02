

using System;

namespace LogicalOperators
{
    class LogicalOperatorsTable
    {
        public static void logicalOp()
        {
            // Conditional AND (&&)
            Console.WriteLine("Conditional AND (&&)");
            Console.WriteLine($"false && false: {false && false}");
            Console.WriteLine($"false && true : {false && true}");
            Console.WriteLine($"true  && false: {true && false}");
            Console.WriteLine($"true  && true : {true && true}");

            // Boolean logical AND (&)
            Console.WriteLine("\nBoolean logical AND (&)");
            Console.WriteLine($"false & false: {false & false}");
            Console.WriteLine($"false & true : {false & true}");
            Console.WriteLine($"true  & false: {true & false}");
            Console.WriteLine($"true  & true : {true & true}");

            // Conditional logical OR (||)
            Console.WriteLine("\nConditional logical OR (||)");
            Console.WriteLine($"false || false: {false || false}");
            Console.WriteLine($"false || true : {false || true}");
            Console.WriteLine($"true  || false: {true || false}");
            Console.WriteLine($"true  || true : {true || true}");

            // Boolean logical inclusive OR (|)
            Console.WriteLine("\nBoolean logical inclusive OR (|)");
            Console.WriteLine($"false | false: {false | false}");
            Console.WriteLine($"false | true : {false | true}");
            Console.WriteLine($"true  | false: {true | false}");
            Console.WriteLine($"true  | true : {true | true}");
        }
    }
}
