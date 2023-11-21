using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GameOfWar
{
    internal class GameOfWars
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine

                (@"
================================================================================
|| Welcome to the Game of War!                                                ||
||                                                                            ||
|| HOW TO PLAY:                                                               ||
|| + Each of the two players are dealt one half of a shuffled deck of cards.  ||
|| + Each turn, each player draws one card from their deck.                   ||
|| + The player that drew the card with higher value gets both cards.         ||
|| + Both cards return to the winner's deck.                                  ||
|| + If there is a draw, both players place the next three cards face down    ||
|| and then another card face-up. The owner of the higher face-up             ||
|| card gets all the cards on the table.                                      ||
||                                                                            ||
|| HOW TO WIN:                                                                ||
|| + The player who collects all the cards wins.                              ||
||                                                                            ||
|| CONTROLS:                                                                  ||
|| + Press [Enter] to draw a new card until we have a winner.                 ||
||                                                                            ||
|| Have fun!                                                                  ||
================================================================================

               ");

            List<Cards> deck = GenerateDeck();

            ShuffleDeck(deck);

            Queue<Cards> firstPlayerDeck = new Queue<Cards>();
            Queue<Cards> secondPlayerDeck = new Queue<Cards>();

            DealCardsToPlayers();

            Cards firstPlayerCards;
            Cards secondPlayerCards;

            int totalMoves = 0;

            while (!GameHasWinner)
            {
                Console.ReadLine();

                DrawPlayersCards();

                Queue<Cards> pool = new Queue<Cards>();

                pool.Enqueue(firstPlayerCards);
                pool.Enqueue(secondPlayerCards);

                ProcessWar(pool);

                DeterminRoundWinner(pool);

                Console.WriteLine("================================================================================");
                Console.WriteLine($"First player curuntely has {firstPlayerDeck.Count} cards.");
                Console.WriteLine($"Second player suruntely has {secondPlayerDeck.Count} cards");
                Console.WriteLine("================================================================================");

                totalMoves++;
            }
            List<Cards> GenerateDeck()
            {
                List<Cards> deck = new List<Cards>();
                Faces[] faces = (Faces[])Enum.GetValues(typeof(Faces));
                Suits[] suits = (Suits[])Enum.GetValues(typeof(Suits));

                for (int suite = 0; suite < suits.Length; suite++)
                {
                    for (int face = 0; face < faces.Length; face++)
                    {
                        Faces curruntFace = faces[face];
                        Suits curruntSuits = suits[face];

                        deck.Add(new Cards

                        {
                            Face = curruntFace,
                            Suits = curruntSuits
                        });
                    }
                }
                return deck;

            }
        }
    }
}

       
