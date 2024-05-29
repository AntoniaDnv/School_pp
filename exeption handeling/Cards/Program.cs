namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            char[] validFacesLetters = {'J', 'Q', 'K', 'A', '2','3', '4','5','6','7','8','9' };
            List<char> faces = new List<char>(validFacesLetters);
            char[] validSuits = { 'S', 'H', 'D', 'C' };
            List<char> suits = new List<char>(validSuits);
            string[] deck = Console.ReadLine()
                .Split(", ");
            for(int i = 0; i < deck.Length; i++)
            {
                try
                {
                    string[] card = deck[i].Split();
                    if (!( faces.Contains(char.Parse(card[0])) && suits.Contains(char.Parse(card[1]))))
                    {
                        throw new Exception("$Invalid card!");
                    }
                    Card cardDeck = new Card(char.Parse(card[0]), char.Parse(card[1]));
                    Console.WriteLine(cardDeck.ToString());
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }

            }
                
        }

    }

    public class Card
    {
        private char cardFace;
        private char cardSuit;

        public char CardFace
        {
            get { return cardFace; }
            set { cardFace = value; }
        }
        public char CardSuits
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }


        public Card(char cardFace, char cardSuit) 
        {
            this.CardFace = cardFace;
            this.CardSuits = cardSuit;
        }
        public override string ToString()
        {
            return $"[{CardFace}{CardSuits}]";
        }

    }
    


}