namespace zad3
{
    internal class zad3
    {
        static void Main(string[] args)
        {
           
            string name = Console.ReadLine();
            string command = Console.ReadLine();
            int succesfull = 0;
            int unsuccesfull = 0;
            bool isWon = false;
            int score = 301;

            while (command != "Retire")
            {
                int points = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case "Double":
                        points *= 2;
                        break;
                    case "Triple":
                        points *= 3;
                        break;

                }
                if (score - points >= 0)
                {
                    score -= points;
                    succesfull++;
                }
                else
                {
                    unsuccesfull++;
                }
                if(score == 0)
                {
                    isWon = true;
                    break;
                }
                command = Console.ReadLine();

            }
            if (isWon)
            {
                Console.WriteLine($"{name} won the leg with {succesfull} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {unsuccesfull} unsuccessful shots.");
            }
        }
    }
}