using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class _27_ListCollections
    {
        public void Collection()
        {
            var items = new List<string>();
            var items2 = new List<string>(6); // Initial capacity of 6


            Console.WriteLine("Before adding to items  " +
                "Count: " + items.Count +
                " Capacit: " + items.Capacity);

            items.Add("Red"); // Add method to add an item to the list
            items.Insert(0, "Green"); // Insert method to add an item at a specific index
            items.AddRange(new List<string> { "Black", "White", "Pink" }); // AddRange method to add multiple items
            Console.WriteLine("After adding to items  " +
                "Count: " + items.Count +
                " Capacit: " + items.Capacity);

            //Displaying items in the list
            Console.WriteLine("Items in the list:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            // Display items using for loop
            Console.WriteLine("Items in the list using for loop:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);

            }

            items.Add("Blue");
            items.Add("Yellow");
            Console.WriteLine("After adding two  more items  " +
                "Count: " + items.Count +
                " Capacit: " + items.Capacity);

            Console.WriteLine("Items in the list after adding more items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            items.Remove("Green"); // Remove method to remove an item by value
            items.RemoveAt(2); // RemoveAt method to remove an item at a specific index
            items.RemoveRange(0, 1); // RemoveRange method to remove a range of items
            Console.WriteLine("After removing items  " +
                "Count: " + items.Count +
                " Capacit: " + items.Capacity);
            Console.WriteLine("Items in the list after removing items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            // Check if an item exists in the list
            bool hasRed = items.Contains("Red");
            Console.WriteLine("List contains 'Red': " + hasRed);

            items.Add("orange");// add and of the list
            items.Add("violet");
            items.Add("red");
            int redIndex = items.IndexOf("red");
            Console.WriteLine("Index of 'red': " + redIndex);

            items.Sort(); // Sort method to sort the list
            Console.WriteLine("Items in the list after sorting:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Last  " +
                "Count: " + items.Count +
                " Capacit: " + items.Capacity);

            

            items.TrimExcess(); // TrimExcess method to set the capacity to the actual number of items
            // use in the final stage to optimize memory usage

            Console.WriteLine("After trimming excess  " +
                "Count: " + items.Count +
                " Capacit: " + items.Capacity);

            items.Clear(); // Clear method to remove all items from the list
            Console.WriteLine("After clearing the list  " +
                "Count: " + items.Count +
                " Capacit: " + items.Capacity);
        }
    }
}