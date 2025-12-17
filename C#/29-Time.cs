using System;

// Time1 sınıfı: 24 saatlik zaman formatını tutar
public class Time1
{
    // Saat, dakika ve saniye için public özellikler
    public int Hour { get; set; }    // 0 - 23
    public int Minute { get; set; }  // 0 - 59
    public int Second { get; set; }  // 0 - 59

    // Zamanı ayarlayan metod; geçersiz değerlerde istisna fırlatır
    public void SetTime(int hour, int minute, int second)
    {
        if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) || (second < 0 || second > 59))
        {
            throw new ArgumentOutOfRangeException("Zaman değerleri geçersiz.");
        }

        Hour = hour;
        Minute = minute;
        Second = second;
    }

    // Evrensel zaman formatında (HH:MM:SS) string'e dönüştürür
    public string ToUniversalString() =>
        $"{Hour:D2}:{Minute:D2}:{Second:D2}";

    // Standart zaman formatında (HH:MM:SS AM/PM) string'e dönüştürür
    public override string ToString() =>
        $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
        $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
}


class Time1Test
{
    public void test()
    {
        // Time1 nesnesi oluşturuluyor
        var time = new Time1(); // varsayılan constructor çağrılır
        
        // Başlangıç zamanını yazdır
        Console.WriteLine($"The initial universal time is: {time.ToUniversalString()}");
        Console.WriteLine($"The initial standard time is: {time.ToString()}");
        Console.WriteLine();

        // Zamanı değiştir ve güncellenmiş zamanı yazdır
        time.SetTime(13, 27, 6);
        Console.WriteLine($"Universal time after SetTime is: {time.ToUniversalString()}");
        Console.WriteLine($"Standard time after SetTime is: {time.ToString()}");
        Console.WriteLine();

        // Geçersiz zaman değerleri denemesi
        try
        {
            time.SetTime(99, 99, 99); // geçersiz değerler
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message + "\n");
        }

        // Geçersiz girişten sonra zamanı tekrar yazdır
        Console.WriteLine("After attempting invalid settings:");
        Console.WriteLine($"Universal time: {time.ToUniversalString()}");
        Console.WriteLine($"Standard time: {time.ToString()}");
    }
}
