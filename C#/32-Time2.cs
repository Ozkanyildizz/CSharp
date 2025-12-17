using System;



public class Time2Test
{
    public void test()
    {
        // Overloaded constructor'larla Time2 nesneleri oluşturuluyor
        var t1 = new Time2();                  // 00:00:00
        var t2 = new Time2(2);                 // 02:00:00
        var t3 = new Time2(21, 34);            // 21:34:00
        var t4 = new Time2(12, 25, 42);        // 12:25:42
        var t5 = new Time2(t4);                // t4'ün kopyası

        Console.WriteLine("Constructed with:\n");

        Console.WriteLine("t1: all arguments defaulted");
        Console.WriteLine($"   {t1.ToUniversalString()}");
        Console.WriteLine($"   {t1.ToString()}\n");

        Console.WriteLine("t2: hour specified; minute and second defaulted");
        Console.WriteLine($"   {t2.ToUniversalString()}");
        Console.WriteLine($"   {t2.ToString()}\n");

        Console.WriteLine("t3: hour and minute specified; second defaulted");
        Console.WriteLine($"   {t3.ToUniversalString()}");
        Console.WriteLine($"   {t3.ToString()}\n");

        Console.WriteLine("t4: hour, minute and second specified");
        Console.WriteLine($"   {t4.ToUniversalString()}");
        Console.WriteLine($"   {t4.ToString()}\n");

        Console.WriteLine("t5: Time2 object t4 specified");
        Console.WriteLine($"   {t5.ToUniversalString()}");
        Console.WriteLine($"   {t5.ToString()}");

        // Geçersiz değerlerle t6 oluşturulmaya çalışılıyor
        try
        {
            var t6 = new Time2(27, 74, 99); // geçersiz değerler
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("\nException while initializing t6:");
            Console.WriteLine(ex.Message);
        }
    }
}




public class Time2
{
    private int hour;   // 0 - 23
    private int minute; // 0 - 59
    private int second; // 0 - 59

    // 0, 1, 2 veya 3 parametreyle çağrılabilen constructor
    public Time2(int hour = 0, int minute = 0, int second = 0)
    {
        SetTime(hour, minute, second); // doğrulama için
    }

    // Başka bir Time2 nesnesiyle kopyalama constructor'ı
    public Time2(Time2 time)
        : this(time.Hour, time.Minute, time.Second) { }

    // Zamanı ayarlayan metod
    public void SetTime(int hour, int minute, int second)
    {
        Hour = hour;     // property üzerinden doğrulama yapılır
        Minute = minute;
        Second = second;
    }

    // Saat property’si (doğrulama içerir)
    public int Hour
    {
        get => hour;
        set
        {
            if (value < 0 || value > 23)
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Hour)} must be 0-23");
            hour = value;
        }
    }

    // Dakika property’si
    public int Minute
    {
        get => minute;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Minute)} must be 0-59");
            minute = value;
        }
    }

    // Saniye property’si
    public int Second
    {
        get => second;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Second)} must be 0-59");
            second = value;
        }
    }

    // Evrensel zaman formatı (HH:MM:SS)
    public string ToUniversalString() =>
        $"{Hour:D2}:{Minute:D2}:{Second:D2}";

    // Standart zaman formatı (1:00:55 AM/PM)
    public override string ToString() =>
        $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
        $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";

    // this ile metot çağrısı (hem açık hem örtük kullanım)
    public string BuildString() =>
        $"{this.ToUniversalString(),24}: {this.ToUniversalString()}" +
        $"\n{ToUniversalString(),24}: {ToUniversalString()}";

}
