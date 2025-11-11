using System;

namespace Program
{
    public class DeckOfCards
    {
        private const int NumberOfCards = 52;
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0;
        private static readonly Random randomNumbers = new Random();

        public DeckOfCards()
        {
            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six",
                           "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };


            for (int i = 0; i < NumberOfCards; i++)
            {
                string face = faces[i % 13];
                string suit = suits[i / 13];
                deck[i] = new Card(face, suit);
            }
        }

        // Tek geçişli karıştırma (Fisher–Yates benzeri, burada basit swap yöntemi)
        public void Shuffle()
        {
            currentCard = 0; // yeniden dağıtıma başla
            for (int first = 0; first < NumberOfCards; first++)
            {
                int second = randomNumbers.Next(NumberOfCards); // 0..51 arası rastgele
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        // Bir kart dağıtır; kart kalmadıysa null döner
        public Card DealCard()
        {
            if (currentCard < NumberOfCards)
                return deck[currentCard++];
            else
                return null;
        }
    }
}


 