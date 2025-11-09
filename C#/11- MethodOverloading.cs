using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareTest
{
    public static int Test(int y ) {
        Console.WriteLine("Called Square with int argument ");
        return y*y;
    }
    public static double Test(double y)
    {
        Console.WriteLine("Called Square with double argument ");

        return y * y;
    }

    public static int OptionalTest(int y = 10)
    {
        Console.WriteLine("Called with an optional parameter");
        return y*y;
    }
}

class TimeSetter
{
    public void SetTime(int hour = 0, int minute = 0, int second = 0)
    {
        Console.WriteLine($"Time: {hour:D2}:{minute:D2}:{second:D2}");
    }
}
