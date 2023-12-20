using System.Reflection;

namespace monsterExterminator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] monster = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();
           
            int[] hero = Console.ReadLine()
               .Split(",")
               .Select(int.Parse)
               .ToArray();
           
            int counter = 0;
            int test = hero[hero.Length - 1];
            int test2 = monster[0];
            for (int i = 0; i < monster.Length; i++)
            {
                if (monster[i] <= hero[hero.Length-i-1])
                {
                    counter++;
                    hero[hero.Length - i -2] = hero[hero.Length - i - 2] + ( hero [hero.Length - i - 1] - monster[i]);

                    monster[i] = 0;


                }
            }
            int checker = monster[monster.Length - 1];
            if (checker == 0)
            {
                Console.WriteLine("All monsters have been killed!");
               
            }
            else
            {
                Console.WriteLine("The solder has been defeated.");
            }
            Console.WriteLine($"Total monsters killed:{counter}");
         

        }
    }
}