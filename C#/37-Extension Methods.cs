using System;


/*
Extension methods provide a way to add new methods to existing types
    without modifying the original type or creating a new derived type.
    They are defined as static methods in a static class,
    and the first parameter specifies the type they extend,
    preceded by the this modifier.

İlk parametre this ile başlamalı
Bu this ifadesi, hangi türü genişlettiğini belirtir
 public static void DisplayTime(this Time2 aTime)

 */

/*

If a type for which you declare an extension method already defines an 
instance method with the same name and a compatible signature, the 
instance method will shadow (i.e., hide) the extension method. 
If a predefined type is later updated to include an instance method that 
shadows an extension method, the compiler does not report any errors 
and the extension method does not appear in IntelliSense
 
 */
static class TimeExtensions
{
    // Zamanı ekrana yazdıran metot
    public static void DisplayTime(this Time2 aTime)
    {
        Console.WriteLine(aTime.ToString());
    }

    // Belirtilen saat kadar ekleyip yeni Time2 döndürür
    public static Time2 AddHours(this Time2 aTime, int hours)
    {
        var newTime = new Time2
        {
            Minute = aTime.Minute,
            Second = aTime.Second,
            Hour = (aTime.Hour + hours) % 24
        };

        return newTime;
    }
}


class TimeExtensionsTest
{
    public void test()
    {
        var myTime = new Time2();
        myTime.SetTime(11, 34, 15);

        Console.Write("Use the DisplayTime extension method: ");
        myTime.DisplayTime();

        Console.Write("Add 5 hours with the AddHours extension method: ");
        var timeAdded = myTime.AddHours(5);
        timeAdded.DisplayTime();

        Console.Write("Add 15 hours with the AddHours extension method: ");
        myTime.AddHours(15).DisplayTime();

        Console.Write("Use fully qualified extension-method name: ");
        TimeExtensions.DisplayTime(myTime);
    }
}