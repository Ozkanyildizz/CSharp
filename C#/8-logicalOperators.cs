using System;

namespace Program
{
    class LogicalOperatorsTable
    {
     
        /// C#'taki temel mantıksal operatörlerin (boolean) doğruluk tablolarını konsola yazdırır.
                public static void logicalOp()
                {   
            // --- KOŞULLU OPERATÖRLER (KISA DEVRE YAPAN) ---
            // Bu operatörler (&& ve ||) gereksiz değerlendirmeyi önler.

            // Koşullu VE (&&) - Conditional AND
            // Sadece her iki işlenen de 'true' ise 'true' döndürür.
            // ÖNEMLİ (Kısa Devre): Sol taraf 'false' ise, sağ tarafı HİÇ DEĞERLENDİRMEZ.
            // Bu, 'null' kontrolleri veya performans için çok kullanışlıdır.
            Console.WriteLine("--- Koşullu VE (&&) ---");
            Console.WriteLine($"false && false: {false && false}"); // False
            Console.WriteLine($"false && true : {false && true}");  // False
            Console.WriteLine($"true  && false: {true && false}"); // False
            Console.WriteLine($"true  && true : {true && true}");  // True

            // Koşullu VEYA (||) - Conditional OR
            // İşlenenlerden en az biri 'true' ise 'true' döndürür.
            // ÖNEMLİ (Kısa Devre): Sol taraf 'true' ise, sağ tarafı HİÇ DEĞERLENDİRMEZ.
            Console.WriteLine("\n--- Koşullu VEYA (||) ---");
            Console.WriteLine($"false || false: {false || false}"); // False
            Console.WriteLine($"false || true : {false || true}");  // True
            Console.WriteLine($"true  || false: {true || false}"); // True
            Console.WriteLine($"true  || true : {true || true}");  // True


            // --- MANTIKSAL OPERATÖRLER (HER ZAMAN DEĞERLENDİREN) ---
            // Bu operatörler (&, |, ^) her zaman her iki tarafı da değerlendirir.
            // Genellikle bit düzeyinde (bitwise) işlemler için kullanılsa da,
            // boolean üzerinde de çalışırlar.

            // Mantıksal VE (&) - Logical AND
            // Sadece her iki işlenen de 'true' ise 'true' döndürür.
            // Fark: Sol taraf 'false' olsa bile sağ tarafı YİNE DE DEĞERLENDİRİR.
            Console.WriteLine("\n--- Mantıksal VE (&) ---");
            Console.WriteLine($"false & false: {false & false}"); // False
            Console.WriteLine($"false & true : {false & true}");  // False
            Console.WriteLine($"true  & false: {true & false}"); // False
            Console.WriteLine($"true  & true : {true & true}");  // True

            // Mantıksal Kapsayıcı VEYA (|) - Logical inclusive OR
            // İşlenenlerden en az biri 'true' ise 'true' döndürür.
            // Fark: Sol taraf 'true' olsa bile sağ tarafı YİNE DE DEĞERLENDİRİR.
            Console.WriteLine("\n--- Mantıksal Kapsayıcı VEYA (|) ---");
            Console.WriteLine($"false | false: {false | false}"); // False
            Console.WriteLine($"false | true : {false | true}");  // True
            Console.WriteLine($"true  | false: {true | false}"); // True
            Console.WriteLine($"true  | true : {true | true}");  // True

            // Mantıksal Özel VEYA (XOR) (^) - Logical exclusive OR
            // (Senin yorumunda | yazıyordu, doğrusu ^ işaretidir.)
            // İşlenenler birbirinden FARKLI ise 'true' döndürür. 
            // İkisi de aynıysa (true, true veya false, false) 'false' döndürür.
            Console.WriteLine("\n--- Mantıksal Özel VEYA (XOR) (^) ---");
            Console.WriteLine($"false ^ false: {false ^ false}"); // False (ikisi de aynı)
            Console.WriteLine($"false ^ true : {false ^ true}");  // True  (farklılar)
            Console.WriteLine($"true  ^ false: {true ^ false}"); // True  (farklılar)
            Console.WriteLine($"true  ^ true : {true ^ true}");  // False (ikisi de aynı)

            // --- EKSİK OPERATÖR: DEĞİL (!) ---

            // Mantıksal DEĞİL (!) - Logical NOT (Negation)
            // Tek bir işlenen alır (unary) ve onun boolean değerini TERSİNE ÇEVİRİR.
            Console.WriteLine("\n--- Mantıksal DEĞİL (!) ---");
            Console.WriteLine($"!true : {!true}");   // False
            Console.WriteLine($"!false: {!false}"); // True
        }
    }
}