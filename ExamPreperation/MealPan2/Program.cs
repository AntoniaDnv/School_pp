namespace MealPan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] food = Console.ReadLine()
                .Split();

            int[] calories = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int mealCalorie = 0;

            int a = 0;

            for (int i = 0; i < calories.Length; i++)
            {
                
                switch (food[a])
                {
                    case "salad":
                        mealCalorie = 350;
                        break;
                    case "soup":
                        mealCalorie = 490;
                        break;
                    case "pasta":
                        mealCalorie = 680;
                        break;
                    case "steak":
                        mealCalorie = 790;
                        break;
                }

                calories[calories.Length - i - 1] = calories[calories.Length - i - 1] - mealCalorie;
                
              
                
                int test = calories[calories.Length - i - 1];
                
                if (test < 0)
                {
                  int  mealleft = mealCalorie + calories[calories.Length - i - 1];
                    if (calories[0] < 0)
                    {
                        Console.WriteLine($"John ate enough, he had {a + 1} meals.");
                        return;
                    }
                    int test2 = calories[calories.Length - i - 2];
                    calories[calories.Length - i - 2] = calories[calories.Length - i - 2] - ( mealCalorie - mealleft);
                    Console.WriteLine(calories[calories.Length - i - 2]);

                    i++;
                }

                if( a >= food.Length- 1)
                {
                    Console.WriteLine($"John had {a + 1} meals.");
                    Console.WriteLine($"For the next few days, he can eat { string.Join(", ", calories)} calories.");
                    return;
                }
                a++;
                if (calories[calories.Length - i - 1] > 0)
                {
                    i--;
                }
                
                
                
            }
        }
    }
}