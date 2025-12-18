using System;

public struct Point
{
    // Public alanlar (struct içinde field veya property olabilir)
    public int X;
    public int Y;

    // Parametreli constructor tanımlayabilirsin parametrelsiz constructor tanımlayamazsın
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // ToString override ile okunabilir çıktı
    public override string ToString() => $"({X}, {Y})";

    // İki Point'i toplamak için operator overloading
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }
}

class StrustTest
{
    public void test()
    {
        // 1️⃣ Default constructor → derleyici otomatik sağlar
        Point p1 = new Point(); // X=0, Y=0
        Console.WriteLine($"Default: {p1}");

        // 2️⃣ Parametreli constructor kullanımı
        Point p2 = new Point(3, 4);
        Console.WriteLine($"Parametreli: {p2}");

        // 3️⃣ Struct değer tipi olduğu için kopyalama davranışı
        Point p3 = p2; // p3 ayrı bir kopya
        p3.X = 10;
        Console.WriteLine($"Orijinal: {p2}, Kopya: {p3}");

        // 4️⃣ Operator overloading ile toplama
        Point sum = p2 + p3 +p2;
        Console.WriteLine($"Toplama: {sum}");
    }
}
