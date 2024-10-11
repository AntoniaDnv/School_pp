
namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] faces = new string[13] {"2",  "3", "4", "5", "6", "7", "8", "9","10", "A", "J", "K", "Q"};
            string[] suits = new string[4] { "Spades", "Diamonds", "Clubs", "Hearts" };

            List<Card> cards = new List<Card>();    
            for (int i = 0; i < faces.Length; i++) 
            {
                foreach (string suite in suits) 
                {
                    cards.Add(new Card() { Face = faces[i], Suit = suite });
                }

            }

            Random random = new Random();

            for (int i = 0; i < cards.Count; i++) 
            {
             
                int randomIndex = random.Next(0, cards.Count);
                Card oldCard = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = oldCard;

            }

            foreach(Card card in cards)
            {
                card.Print();
            }

        }
    }
}
