namespace pregovorPrediTest10klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();

            string[] input = Console.ReadLine()
                 .Split();
            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Add":
                        deck.Add(new Card(input[1], input[2]));
                        break;

                    case "Print":
                        deck.Print();
                        break;

                    case "GetAllCards":
                        deck.GetAllCards();
                        break;

                    case "Randomize":
                        deck.Shuffle();
                        break;

                    case "Clear":
                        deck.Clear();
                        break;
                }
                input = Console.ReadLine()
                 .Split();
            }
                
        }
    }
}
