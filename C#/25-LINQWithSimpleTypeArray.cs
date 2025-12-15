using System;
using System.Globalization;
using System.Linq;

namespace C_
{
    internal class _25_LINQWithSimpleTypeArray
    {
        public void LINQWithSimpleTypeArray()
        {
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Original array: ");
            print(values);

            var filtered = from value in values
                           where value % 2 == 0
                           select value;

            Console.Write("\nArray values which are even.");
            print(filtered.ToArray());


            var sortedDescending = from value in values
                         orderby value descending
                         select value;

            Console.Write("\nArray values sorted in descending order.");
            print(sortedDescending.ToArray());

            var sortedAscending = from value in values
                                orderby value ascending
                                select value;
            Console.Write("\nArray values sorted in ascending order.");
            print(sortedAscending.ToArray());

            var transformed = from value in values
                              select value * value;
            Console.Write("\nArray values squared.");
            print(transformed.ToArray());

            var combined = from value in values
                           where value % 2 != 0
                           orderby value descending
                           select value * value * value;
            Console.Write("\nArray values which are odd, sorted in descending order and cubed.");
            print(combined.ToArray());

            
        }
        public void print(int[] data)
        {
            foreach (int v in data)
            {
                Console.Write($" {v}");
            }
        }
    }
}
