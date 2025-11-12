using System;


namespace Program
{
    internal class MultiDimensionalArrays
    {
        public void multiDimensionalArrays() {

            Console.WriteLine("Multi Dimensional Array: ");



           int[,] rectengular = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

           int[][] jogged = { new int[] { 1,2,3},
                              new int[] {2,3,4 },
                              new int[] { 3} };

            int[][] array3;
            array3 = new int[3][];
            array3[0] = new int[] { 1, 2, 3 };
            array3[1] = new int[] { 4, 5 };
            array3[2] = new int[] { 6, 7, 8, 9 };

            printArray(rectengular);
            printArray(jogged);



        }

        public void printArray(int[,] array)
        {
            Console.WriteLine("Rectengular Array:");
            for (int  i = 0;  i < array.GetLength(0);  i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public void printArray(int[][] array)
        {
            Console.WriteLine("Jagged Array:");
            foreach (var row in array)
            {
                foreach (var item in row)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }

}
