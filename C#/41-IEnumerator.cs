using System;
using System.Collections;
using System.Collections.Generic;

// Özel koleksiyon sınıfı
public class CustomCollection : IEnumerable<int>
{
    private int[] numbers = { 10, 20, 30, 40 };

    // IEnumerable implementasyonu → foreach için gerekli
    public IEnumerator<int> GetEnumerator()
    {
        return new CustomEnumerator(numbers);
    }

    // IEnumerable'ın klasik versiyonu (non-generic)
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Özel enumerator sınıfı
public class CustomEnumerator : IEnumerator<int>
{
    private int[] _items;
    private int _position = -1;

    public CustomEnumerator(int[] items)
    {
        _items = items;
    }

    public int Current => _items[_position];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        _position++;
        return (_position < _items.Length);
    }

    public void Reset()
    {
        _position = -1;
    }

    public void Dispose()
    {
        // Kaynak yoksa boş bırakılır
    }
}

// Test sınıfı
class EnumeratorTest
{
    public void test()
    {
        var collection = new CustomCollection();

        Console.WriteLine("CustomCollection içeriği:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}
