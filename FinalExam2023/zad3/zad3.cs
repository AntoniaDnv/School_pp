namespace zad3
{
    internal class zad3
    {
        static void Main(string[] args)
        {
           double goal = double.Parse(Console.ReadLine());
            bool x = true;
            double lives = 3;
            double tries = 0;
            double momentumGoal = goal - 30;

            while (x == true)
            {
               
                double jump = double.Parse(Console.ReadLine());

                if (jump > goal)

                {
                    tries++;
                    Console.WriteLine($"Dimo did it, he reached his goal with {goal}cm. He made {tries} tries.");
                     x = false;
                }
                if (jump > momentumGoal)
                {
                    momentumGoal += 5;

                    lives = 3;
                    tries ++;
                }
                else if(jump <= momentumGoal)
                {
                    lives --;
                    tries ++;

                }
                

                if (lives <= 0)
                {
                    Console.WriteLine($"{momentumGoal}cm was too hard for Dimo to reach. He made {tries} tries.");
                    
                     x = false;

                }
                
            }
        }
    }
}