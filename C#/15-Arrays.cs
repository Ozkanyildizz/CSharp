using System;


namespace Program
{
    class Arrays
    {
        public static void arrays()
        {
            //int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray = new int[10];    
            
            Console.WriteLine($"{"Index"}{ "value",8}");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
                Console.WriteLine($"{i}{myArray[i]*2,8}");
            }

            Console.WriteLine("myAray with foreach ");
            int total = 0;

            foreach (int i in myArray)
            {
                total = total + i;
            }

            Console.WriteLine($"Total of array is: {total}");
        }
        public static void rollDie()
        {
            var randomNumbers = new Random();
            var freaquency = new int [7];

            for (int roll = 0; roll < 6000; roll++)
            {
                ++freaquency[randomNumbers.Next(1, 7)];
            }

            for(var face =1; face < freaquency.Length; face++)
            {
                Console.WriteLine($"{face}{freaquency[face],8}");
            }
        }

    }
}
