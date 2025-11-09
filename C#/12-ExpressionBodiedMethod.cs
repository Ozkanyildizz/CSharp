using System;

internal class ExpressionBodiedMethod
{
     private static string state = "CA";
    public static int Cube(int x) => x * x * x;
    public static bool IsNaFaultState => state == "NA" || state == "MA " || state == "NJ" || state == "CA";

    
}



