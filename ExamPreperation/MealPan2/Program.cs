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
                int test = calories[calories.Length - i - 1];
                if (test < 0)
                {
                    mealCalorie = mealCalorie + calories[calories.Length - i - 1];
                }
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
                Console.WriteLine(calories[calories.Length - i - 1]);
                if (calories[calories.Length - i - 1] > 0)
                {
                    i--;
                }
                a++;
                
                
            }
        }
    }
}