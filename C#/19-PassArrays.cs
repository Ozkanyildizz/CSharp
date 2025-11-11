
using System;

class PassArray
{
    public static void pass()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Tüm diziyi referans olarak göndermenin etkileri:");
        Console.WriteLine("Dizinin orijinal değerleri:");

        foreach (var value in array)
        {
            Console.Write($"{value} "); // Çıktı: 1 2 3 4 5
        }

        ModifyArray(array);
        Console.WriteLine("\n\nDeğiştirilmiş dizinin değerleri:");

        foreach (var value in array)
        {
            Console.Write($"{value} "); // Çıktı: 2 4 6 8 10
        }

        Console.WriteLine("\n\nDizi elemanını değer olarak göndermenin etkileri:");
        Console.WriteLine($"ModifyElement'ten önce array[3] değeri: {array[3]}"); // Çıktı: 8

        ModifyElement(array[3]);
        Console.WriteLine($"ModifyElement'ten sonra array[3] değeri: {array[3]}"); // Çıktı: 8
    }

    public static void ModifyArray(int[] theArray)
    {
        for (int i = 0; i < theArray.Length; i++)
        {
            theArray[i] *= 2; // Dizinin orijinal elemanlarını 2 ile çarpar
        }
    }


    public static void ModifyElement(int element)
    {
        element *= 2; // Sadece parametrenin kopyasını 2 ile çarpar
        Console.WriteLine($"ModifyElement metodu içindeki elemanın değeri: {element}"); // Çıktı: 16
    }
}