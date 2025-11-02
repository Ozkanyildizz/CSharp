using System;



namespace Format_Specifier
{
    class Format_specifier
    {
        public void specifier()
        {
            // -----------------------------------------------------------------
            // Format specifier examples (örnekler ve kısa açıklamalar)
            //
            // Format specifier | Açıklama
            // C or c          | Currency (para birimi). Kültüre göre sembol ve iki ondalık (örn. $150.00 veya 150,00 ₺)
            // D or d          | Decimal / integer (tam sayılar için). Sıfır dolgulu genişlik kullanılabilir (örn. D6).
            // N or n          | Number with thousands separator (binlik ayırıcı) ve varsayılan iki ondalık.
            // E or e          | Scientific (bilimsel gösterim, örn. 1.500000E+002)
            // F or f          | Fixed-point (sabit ondalık sayıda basamak, varsayılan iki).
            // G or g          | General (sayıya göre fixed-point veya scientific seçer; varsayılan biçim).
            // X or x          | Hexadecimal (tam sayılar için). X -> büyük harfli, x -> küçük harfli hex.
            //
            // Örnekler (Console.WriteLine ile):
            decimal amount = 12345.6789m;
            int intValue = 42;

            // :C -> Currency
            Console.WriteLine($"{amount:C}");      // örn. "₺12.345,68" veya "$12,345.68" (kültüre göre)

            // :D -> Decimal (tam sayılar). D6 -> en az 6 haneli, gerekirse başa sıfır ekler
            Console.WriteLine($"{intValue:D6}");   // "000042"

            // :N -> Number with thousands separator (N2 -> iki ondalık)
            Console.WriteLine($"{amount:N2}");     // "12,345.68" veya "12.345,68" (kültüre göre)

            // :E -> Scientific notation
            Console.WriteLine($"{amount:E}");      // "1.234568E+004" (varsayılan 6 ondalık)

            // :F -> Fixed-point with specified decimals (F2 -> iki ondalık)
            Console.WriteLine($"{amount:F2}");     // "12345.68" veya "12345,68" (kültüre göre)

            // :G -> General
            Console.WriteLine($"{amount:G}");      // "12345.6789" veya bilimsel gösterim, değere bağlı olarak

            // :X -> Hexadecimal (tam sayılar için). X büyük harfli, x küçük harfli
            Console.WriteLine($"{intValue:X}");    // "2A"  (hex, uppercase)
            Console.WriteLine($"{intValue:x}");    // "2a"  (hex, lowercase)
            Console.WriteLine($"{intValue:X6}");   // "00002A" (minimum genişlik, sıfır dolgulu)

            // Daha fazla kontrol için precision ekleyebilirsiniz: :C0 (ondalık yok), :F3 (3 ondalık) vb.
            Console.WriteLine($"{amount:C0}");     // para biriminde ondalık olmadan
            Console.WriteLine($"{amount:F3}");     // sabit nokta, 3 ondalık
            // -----------------------------------------------------------------
        }
    }
}
