namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] validFacesLetters = { "J", "Q", "K", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            List<Card> cards = new List<Card>();
            var validSuits = new Dictionary<string, string>()
            {   {"S", "\u2660"},
                { "H", "\u2665"},
                { "D", "\u2666"},
                { "C", "\u2663" } 
            };
          
            string[] deck = Console.ReadLine()
                .Split(", ").ToArray();
            foreach (string face in deck) 
            {
                var cardElement = face.Split().ToArray();
                var cardF = cardElement[0];
                var cardS = cardElement[1];
                try
                {
                  
                    if (!( validFacesLetters.Contains(cardF) || validSuits.ContainsKey(cardS)))
                    {
                        throw new Exception("$Invalid card!");
                    }
                    Card cardDeck = new Card();
                    cardDeck.CardFace = cardF;
                    cardDeck.CardSuits = validSuits[cardS];
                    cards.Add(cardDeck);

                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine(string.Join(' ', cards));
                
        }

    }

    public class Card
    {
        private string? cardFace;
        private string? cardSuit;

        public string CardFace
        {
            get;
            set;
        }
        public string CardSuits
        {
            get;
            set;
        }


        //public Card(string cardFace, Dictionary<string, string> cardSuit) 
        //{
        //    this.CardFace = cardFace;
        //    this.CardSuits = cardSuit;
        //}
        public override string ToString()
        {
            return $"[{CardFace}{CardSuits}]";
        }

    }

}