using System;

class DateTimeTest
{
    public void time()
    {
        // Varsayılan zaman: şimdi
        DateTime now = DateTime.Now;

        Console.WriteLine($"Şu anki zaman (24 saat): {now.ToString("HH:mm:ss")}");
        Console.WriteLine($"Şu anki zaman (AM/PM): {now.ToString("hh:mm:ss tt")}");
        Console.WriteLine();

        // Belirli bir zaman oluştur
        DateTime customTime = new DateTime(2025, 12, 17, 13, 27, 6);
        Console.WriteLine($"Özel zaman: {customTime.ToString("HH:mm:ss")}");

        // Süre farkı hesapla
        TimeSpan fark = now - customTime;
        Console.WriteLine($"Şu an ile özel zaman arasındaki fark: {fark.TotalMinutes:F1} dakika");
    }
}
