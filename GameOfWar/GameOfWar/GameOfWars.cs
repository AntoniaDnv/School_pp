using System.Collections.Generic;
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

            DealCardsToPlayers(deck);

            Cards firstPlayerCards;
            Cards secondPlayerCards;

            int totalMoves = 0;

            while (!GameHasWinner())
            {
                Console.ReadLine();

                DrawPlayerCards();

                Queue<Cards> pool = new Queue<Cards>();

                pool.Enqueue(firstPlayerCards);
                pool.Enqueue(secondPlayerCards);
              ProcessWar(pool);

                DetermineRoundWinner(pool);



                Console.WriteLine("================================================================================");
                Console.WriteLine($"First player curuntely has {firstPlayerDeck.Count} cards.");
                Console.WriteLine($"Second player suruntely has {secondPlayerDeck.Count} cards");
                Console.WriteLine("================================================================================");

                totalMoves++;
            }
            List<Cards> GenerateDeck()
            {
                List<Cards> deck = new List<Cards>();
                CardFace[] faces = (CardFace[])Enum.GetValues(typeof(CardFace));
                CardSuit[] suits = (CardSuit[])Enum.GetValues(typeof(CardSuit));

                for (int suite = 0; suite < suits.Length; suite++)
                {
                    for (int face = 0; face < faces.Length; face++)
                    {
                        CardFace curruntFace = faces[face];
                        CardSuit curruntSuits = suits[suite];

                        deck.Add(new Cards

                        {
                            Face = curruntFace,
                            Suits = curruntSuits
                        });
                    }
                }
                return deck;

            }

            void ShuffleDeck(List<Cards> deck)
            {
                Random rndm = new Random();

                for(int i = 0; i < deck.Count; i++)
                {
                    int firstCardIndex = rndm.Next(deck.Count);
                    Cards tempCard = deck[firstCardIndex];

                    deck[firstCardIndex] = deck[i];

                    deck[i] = tempCard;
                }

            }

            void DealCardsToPlayers( List<Cards> deck)
            {
                while(deck.Count > 0)
                {
                    Cards[] firstTwoDrawnCards = deck.Take(2).ToArray();

                    deck.RemoveRange(0, 2);

                    firstPlayerDeck.Enqueue(firstTwoDrawnCards[0]);
                    secondPlayerDeck.Enqueue(firstTwoDrawnCards[1]);
                }
            }

            bool GameHasWinner()
            {
                if (!firstPlayerDeck.Any())
                {
                    Console.WriteLine($"After a total of {totalMoves} moves, the second player has won!");
                    return true;
                }

                if(!secondPlayerDeck.Any())
                {
                    Console.WriteLine($"After a total of {totalMoves} moves, the second player has won!");
                    return true;
                }
                return false;
            }

            void DrawPlayerCards()
            {
                firstPlayerCards= firstPlayerDeck.Dequeue();

                Console.WriteLine($"First player has drawn: {firstPlayerCards}");

                secondPlayerCards= secondPlayerDeck.Dequeue();
                Console.WriteLine($"Second player has drawn: {secondPlayerCards}");
                Console.WriteLine("================================================================================");

                while (!GameHasWinner())
                {
                    Console.ReadLine();

                    DrawPlayerCards();

                    Queue<Cards> pool = new Queue<Cards>();

                    pool.Enqueue(firstPlayerCards);
                    pool.Enqueue(secondPlayerCards);

                   ProcessWar(pool);
                   DetermineRoundWinner(pool);

                }
            }

            void ProcessWar(Queue<Cards> pool)
            {
                while((int)firstPlayerCards.Face == (int)secondPlayerCards.Face)
                {
                    Console.WriteLine("WAR!");

                    if (firstPlayerDeck.Count < 4)
                    {
                        AddCardsToWinnerDeck(firstPlayerDeck, secondPlayerDeck);

                        Console.WriteLine($"First player does not have enough cards to contunu playnig...");
                        break;
                    }
                    if (firstPlayerDeck.Count < 4)
                    {
                        AddCardsToWinnerDeck(firstPlayerDeck, secondPlayerDeck);

                        Console.WriteLine($"Second player does not have enough cards to contunu playnig...");
                        break;
                    }
                    AddWarCardsToPool(pool);

                    firstPlayerCards = firstPlayerDeck.Dequeue();

                    Console.WriteLine($"First player has drawn: {firstPlayerCards}");

                    secondPlayerCards = secondPlayerDeck.Dequeue();

                    Console.WriteLine($"First player has drawn: {secondPlayerCards}");


                        pool.Enqueue(firstPlayerCards);    
                        pool.Enqueue(secondPlayerCards);
                }
            }

            void AddCardsToWinnerDeck(Queue<Cards> loserDeck, Queue<Cards> winnerDeck)
            {
                while(loserDeck.Count > 0)
                {
                  winnerDeck.Enqueue(loserDeck.Dequeue());
                }
            }

            void AddWarCardsToPool(Queue<Cards> pool)
            {
                for(int i = 0; i < 3; i++)
                {
                    pool.Enqueue(firstPlayerDeck.Dequeue());
                    pool.Enqueue(secondPlayerDeck.Dequeue());
                }
            }

            void DetermineRoundWinner(Queue<Cards> pool)
            {
                if((int)firstPlayerCards.Face > (int)secondPlayerCards.Face)
                {
                    Console.WriteLine("The fist player has won the cards!");

                    foreach(var card in pool)
                    {
                        firstPlayerDeck.Enqueue(card);
                    }
                }
                else
                {
                    Console.WriteLine("The second player has won the cards!");

                    foreach (var card in pool)
                    {
                        secondPlayerDeck.Enqueue(card);
                    }
                }
            }


        }
    }
}

       
