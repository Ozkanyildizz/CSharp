using System;



namespace intro
{
    class İntroduction
    {
       public void introduction()
        {
            Console.Write("Hello C# ");
            Console.WriteLine("HELLO WORLD");
            Console.WriteLine("Welcome\nto\tc#\nprogramming\rlanguage.");

            // \n: Yeni satır
            // \t: Sekme boşluğu
            // \r: Satır başına döner (Windows'ta etkisi sınırlı olabilir)

            Console.Write("What is your name: ");
            string person = Console.ReadLine();
            Console.WriteLine($"Your name is: {person}");

            int number1 = 0;
            int number2 = 0;
            int sum = 0;
            int stop;

            float pi = 3.14f;
            double precise = 3.1415926535;
            char letter = 'A';

            Console.WriteLine(pi + precise + letter);

            while (true)
            {
                number1 = ReadInt("Enter first number: ");
                number2 = ReadInt("Enter second number: ");

                if (number2 == 0)
                {
                    Console.WriteLine("Cannot use 0 as divisor. Try again.");
                    continue;
                }

                sum = number1 % number2;
                Console.WriteLine("sum is: " + sum);

                stop = ReadInt("0 for break 1 for cont: ");

                if (stop == 0)
                {
                    break;
                }
            }

            if (number1 > number2)
                Console.WriteLine("First number is greater.");
        }

        static int ReadInt(string prompt)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input. " + prompt);
            }
            return value;
        }
    }
}
