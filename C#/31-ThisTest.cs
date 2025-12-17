
using System;

class ThisTest
{
    public void test()
    {
        var time = new SimpleTime(15, 30, 19);
        Console.WriteLine(time.BuildString());
    }
}

// class SimpleTime demonstrates the "this" reference
public class SimpleTime
{
    private int hour;   // 0-23
    private int minute; // 0-59
    private int second; // 0-59

    // Constructor'da parametre isimleri ile instance değişkenler aynı,
    // bu yüzden this kullanmak zorunlu
    public SimpleTime(int hour, int minute, int second)
    {
        this.hour = hour;     // this.hour → instance değişken
        this.minute = minute; // this.minute → instance değişken
        this.second = second; // this.second → instance değişken
    }

    // this ile metot çağrısı (hem açık hem örtük kullanım)
    public string BuildString() =>
        $"{this.ToUniversalString(),24}: {this.ToUniversalString()}" +
        $"\n{ToUniversalString(),24}: {ToUniversalString()}";

    // this ile instance değişkenlere erişim (açık kullanım)
    public string ToUniversalString() =>
        $"{this.hour:D2}:{this.minute:D2}:{this.second:D2}";
}
