// Fig. 8.24: InitArray.cs
// Using command-line arguments to initialize an array.

using System;

class InitArray
{
    public static void Test(string[] args)
    {
        // check number of command-line arguments
        if (args.Length != 3)
        {
            Console.WriteLine(
                "Error: Please re-enter the entire command, including\n" +
                "an array size, initial value and increment.");
        }
        else
        {
            // get array size from first command-line argument
            var arrayLength = int.Parse(args[0]);
            var array = new int[arrayLength]; // create array

            // get initial value and increment from command-line argument
            var initialValue = int.Parse(args[1]);
            var increment = int.Parse(args[2]);

            // calculate value for each array element
            for (var counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = initialValue + increment * counter;
            }

            Console.WriteLine("{0,-10}{1,10}", "Index", "Value");

            // display array index and value
            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine("{0,-10}{1,10}", counter, array[counter]);
            }
        }
    }
}
