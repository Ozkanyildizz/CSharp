using System;

class CrapsGame
{
    // Oyun durumlarını tanımlayan enum
    enum Status { CONTINUE, WON, LOST }

    static Random random = new Random();

    private enum DiceNames
    {
        SnakeEyes = 2,
        Trey = 3,
        Seven = 7,
        YoLeven = 11,
        BoxCars = 12
    }


    public static void Play()
    {
        int myPoint = 0;
        Status gameStatus;

        // İlk zar atışı
        int sumOfDice = RollDice();

        // İlk atışa göre oyunun durumunu belirle
        switch (sumOfDice)
        {
            case (int)DiceNames.Seven:
            case (int)DiceNames.YoLeven:
                gameStatus = Status.WON;
                break;

            case (int)DiceNames.SnakeEyes:
            case (int)DiceNames.Trey:
            case (int)DiceNames.BoxCars:
                gameStatus = Status.LOST;
                break;

            default:
                gameStatus = Status.CONTINUE;
                myPoint = sumOfDice;
                Console.WriteLine($"Point belirlendi: {myPoint}");
                break;
        }


        // Oyun devam ediyorsa zar atmaya devam et
        while (gameStatus == Status.CONTINUE)
        {
            sumOfDice = RollDice();

            if (sumOfDice == myPoint)
                gameStatus = Status.WON;
            else if (sumOfDice == 7)
                gameStatus = Status.LOST;
        }

        // Oyunun sonucu
        if (gameStatus == Status.WON)
            Console.WriteLine("Oyuncu kazandı!");
        else
            Console.WriteLine("Oyuncu kaybetti.");
    }

    // Zar atma fonksiyonu
    static int RollDice()
    {
        int die1 = random.Next(1, 7); // 1–6 arası
        int die2 = random.Next(1, 7);
        int sum = die1 + die2;

        Console.WriteLine($"Oyuncu zar attı: {die1} + {die2} = {sum}");
        return sum;
    }
}
