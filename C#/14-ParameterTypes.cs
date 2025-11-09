using System;

class ParameterTypes
{
    public static void Reference()
    {
        int a = 5;     // value parametresi
        int b = 5;     // ref parametresi
        int c;         // out parametresi
        int d = 7;     // in parametresi

        Console.WriteLine("Başlangıçta a: {0}", a);
        Console.WriteLine("Başlangıçta b: {0}", b);
        Console.WriteLine("Başlangıçta d: {0}", d);

        SquareValue(a);           // value → kopya ile çalışır
        SquareRef(ref b);         // ref → doğrudan değiştirir
        SquareOut(out c);         // out → değer atar
        SquareIn(in d);           // in → sadece okur, değiştiremez

        Console.WriteLine("SquareValue sonrası a: {0}", a);   // değişmez
        Console.WriteLine("SquareRef sonrası b: {0}", b);     // değişir
        Console.WriteLine("SquareOut sonrası c: {0}", c);     // atanır
        Console.WriteLine("SquareIn sonrası d: {0}", d);      // değişmez       
    }

    // value parametresi: sadece kopya ile çalışır
    static void SquareValue(int x)
    {
        x = x * x;
    }

    // ref parametresi: çağıranın değişkenini doğrudan değiştirir
    static void SquareRef(ref int x)
    {
        x = x * x;
    }

    // out parametresi: çağıranın değişkenine değer atar
    static void SquareOut(out int x)
    {
        x = 6;
        x = x * x;
    }

    // in parametresi: sadece okur, değiştiremez
    static void SquareIn(in int x)
    {
        Console.WriteLine($"SquareIn içinde x'in karesi: {x * x}");

        // x = x + 1; //  HATA! in parametresi değiştirilemez
    }
}
