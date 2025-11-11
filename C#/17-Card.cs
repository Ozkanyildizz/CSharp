

namespace Program
{

    public class Card
    {
       
        private string Face { get; }

        
        private string Suit { get; }

     
        public Card(string face, string suit)
        {
            Face = face;   
            Suit = suit;   
        }

     // it ovverides the ToString 
        public override string ToString() => $"{Face} of {Suit}";
    }

}
