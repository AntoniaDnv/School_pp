namespace guessingGame_codingEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Try to guess the number!");

            bool playerWantsToPlay = true;

            while (playerWantsToPlay == true)
            {
                Random random = new Random();
                int numToGuess = random.Next(1, 101);
                bool isNumGuessed = false;

                while (isNumGuessed == false)
                {
                    Console.Write("Type your number guess: ");
                    int userNum = int.Parse(Console.ReadLine());

                    if (userNum == numToGuess)
                    {
                        Console.WriteLine("Congratulations you guessed the number corectly!");
                        isNumGuessed = true;
                    }
                    if (userNum > numToGuess)
                    {
                        Console.WriteLine("Try with something lower!");
                    }
                    if (userNum < numToGuess)
                    {
                        Console.WriteLine("Try with something heigher!");
                    }
                }
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                string userResponse = Console.ReadLine();

                if ((userResponse.ToLower() != "yes") || (userResponse.ToLower() != "no"))
                {
                    Console.WriteLine("Invalid answer! Please choose from the options above.");
                    userResponse = Console.ReadLine();  
                } 

                if ((userResponse.ToLower() == "no"))
                {
                    playerWantsToPlay = false;
                }
                else
                {
                    playerWantsToPlay = true;
                }

            }
           
        }
    }
}
