
using System;

namespace Program
{
    class RandomNumbers
    {
        public static void frequencyOFDie()
        {

            Console.WriteLine("Summerize resultf of 60 000 rolls of a 6-sided die:");

            int frequency1 = 0;
            int frequency2 = 0;
            int frequency3 = 0;
            int frequency4 = 0;
            int frequency5 = 0;
            int frequency6 = 0;
            
            Random dieObj = new Random();

            for (int i = 0; i<=60000; i++) {
                 
                int roll = dieObj.Next(1, 7); // 1 to 6 inclusive

                switch (roll)
                {
                    case 1:
                        frequency1++;
                        break;
                    case 2:
                        frequency2++;
                        break;
                    case 3:
                        frequency3++;
                        break;
                    case 4:
                        frequency4++;
                        break;
                    case 5:
                        frequency5++;
                        break;
                    case 6:
                        frequency6++;
                        break;
                    default:
                        break;
                }

                

            }

            Console.WriteLine($"Face\tFrequency");
            Console.WriteLine($"1\t{frequency1}");
            Console.WriteLine($"2\t{frequency2}");
            Console.WriteLine($"3\t{frequency3}");
            Console.WriteLine($"4\t{frequency4}");
            Console.WriteLine($"5\t{frequency5}");
            Console.WriteLine($"6\t{frequency6}");

            Console.WriteLine($"Face\tFrequency");
            Console.WriteLine($"1\t%{(frequency1/60000.0)*100}");
            Console.WriteLine($"2\t%{(frequency2/60000.0)*100}");
            Console.WriteLine($"3\t%{(frequency3/60000.0)*100}");
            Console.WriteLine($"4\t%{(frequency4/60000.0)*100}");
            Console.WriteLine($"5\t%{(frequency5/60000.0)*100}");
            Console.WriteLine($"6\t%{(frequency6/60000.0)*100}");


        }
    }
}
