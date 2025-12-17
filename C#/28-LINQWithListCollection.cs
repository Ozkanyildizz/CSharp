using System;
using System.Collections.Generic;
using System.Linq;


namespace C_
{
    internal class _28_LINQWithListCollection
    {
        public void LINQListCollection()
        {
            var items = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink",
                "Blue",
                "Yellow",
                "Rust",
                "rUby"
            };
            Console.WriteLine("Original items:");
            foreach (var item in items)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
            // Using LINQ to filter items that contain the letter 'e'
            var filteredItems = from item in items
                                where item.Contains("e")
                                select item;
            Console.WriteLine("Filtered items containing 'e':");
            foreach (var item in filteredItems)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
            // Using LINQ method syntax to order items alphabetically
            var orderedItems = items.OrderBy(item => item);
            orderedItems = from item in items
                           orderby item
                           select item;
            Console.WriteLine("Ordered items:");
            foreach (var item in orderedItems)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
            // Convert to uppercase, select those starting with 'R' and sort 

            var startsWithR = from item in items
                              let upperItem = item.ToUpper()
                              where upperItem.StartsWith("R")
                              orderby upperItem
                              select upperItem;
            Console.WriteLine("Items starting with 'R' in uppercase and sorted:");
            foreach (var item in startsWithR)
            {
                Console.Write(" "+item);
            }

            /*
Original items:
 Red Green Black White Pink Blue Yellow Rust rUby
Filtered items containing 'e':
 Red Green White Blue Yellow
Ordered items:
 Black Blue Green Pink Red rUby Rust White Yellow
Items starting with 'R' in uppercase and sorted:
 RED RUBY RUST
            */

            /*
             LINQ uses deferred execution—the query executes only
when you access the results, notwhen you define the query.*/
        }
    }
}
