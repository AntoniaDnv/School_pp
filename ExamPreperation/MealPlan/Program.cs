namespace MealPlan
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

           
                while(calories[calories.Length - 1] > 0)
                {
                    
                    switch (food[i])
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

                    if (calories[calories.Length - i - 1] < 0)
                    {
                        calories[calories.Length - i - 1] = calories[calories.Length - i - 1] + mealCalorie;

                        mealCalorie = mealCalorie - calories[calories.Length - i - 1];

                        calories[calories.Length - i - 2] = calories[calories.Length - i - 2] - mealCalorie;

                        calories[calories.Length - i - 1] = calories[calories.Length - i - 2];
                    }

                    Console.WriteLine(calories[calories.Length - i - 1]);
          
                }
               
            
        }
    }
}