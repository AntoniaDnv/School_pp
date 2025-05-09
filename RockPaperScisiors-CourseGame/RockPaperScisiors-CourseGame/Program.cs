namespace RockPaperScisiors_CourseGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rock, Paper or Scissors!");
            Random random = new Random();
            string playerChoise;
            string computerChoice = "";
            bool playAgain = true;

            while (playAgain)
            {
                Console.Write("Your choice: ");
                string playerChoice = Console.ReadLine().ToUpper();
                string[] validChoices = { "ROCK", "PAPER", "SCISSORS" };

                while (!validChoices.Contains(playerChoice))
                {
                    Console.WriteLine("Invalid input!");
                    playerChoise = Console.ReadLine().ToUpper();
                }
                int playableNum = random.Next(1, 4);

                switch (playableNum)
                {
                    case 1:
                        computerChoice = "ROCK";
                            break;
                    case 2:
                        computerChoice = "PAPER";
                        break;
                    case 3:
                        computerChoice = "SCISSORS";
                        break;
                }
              
                Console.WriteLine($"Computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }

                if ((playerChoice == "ROCK" && computerChoice != "PAPER") ||
                    (playerChoice == "PAPER" && computerChoice != "SCISSORS") ||
                    (playerChoice == "SCISSORS" && computerChoice != "ROCK"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("The computer wins!");
                }

                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("Yes/No");
                string response = Console.ReadLine();
                if (response.ToUpper() == "YES")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain= false;
                    return;
                }

            }
        }
    }
}
