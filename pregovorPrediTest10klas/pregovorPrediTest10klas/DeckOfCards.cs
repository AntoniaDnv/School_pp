using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregovorPrediTest10klas
{
    public class DeckOfCards
    {
      public List<Card> cards = new List<Card> ();

        public DeckOfCards()
        {
            cards = new List<Card> ();
        }

        public void Add (Card card)
        {
            cards.Add (card);
        }

        public void Print()
        {
            if (cards.Count > 0) 
            {
                Console.WriteLine(cards[cards.Count-1]);
            }
            else
            {
                Console.WriteLine("No cards in the deck!");
            }
        }

        public void GetAllCards()
        {
            if (cards.Count>0)
            {
                foreach (Card card in cards)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("No cards in the deck!");
            }
            
        }

        public void Shuffle()
        {
            Random rnd = new Random(); 
            for (int i = 0; i < cards.Count; i++) 
            {
                int random = rnd.Next (0, cards.Count);
                Card oldCard = cards[i];
                cards[i] = cards[random];
                cards[random] = oldCard;          
            }

            foreach (Card card in cards)
            {
                Console.WriteLine (card);
            }
        }

        public void Clear()
        {
            cards.Clear();
            Console.WriteLine("Deck cleared");
        }
    }
}
