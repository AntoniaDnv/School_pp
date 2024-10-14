namespace miriProekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 9");
            Console.WriteLine("1. Прости пресмятания");
            Console.WriteLine("2. Условни конструкции");
            Console.WriteLine("3. Вложени конструкции");
            Console.WriteLine("4. For цикъл");
            Console.WriteLine("5. While цикъл");
            Console.WriteLine("6. Вложени цикли");
            Console.WriteLine("7. Изход");

            Console.WriteLine("Моля въведете една от изброените опции!");
            int option = int.Parse(Console.ReadLine());


            while (option > 0 && option < 7)
            {
                switch (option)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;

                    default:
                        break;
                }

                option = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вие излязохте от програмата!");
        }

        static void Task1()
        {

            int bitcoins = int.Parse(Console.ReadLine());
            double chineese = double.Parse(Console.ReadLine());
            int komissionna = int.Parse(Console.ReadLine());
            Console.WriteLine((bitcoins * 1168 + chineese * 0.15 * 1.76) / 1.95 - (bitcoins * 1168 + chineese * 0.15 * 1.76) * 1.95 * 5.0 / 100);
        }
        static void Task2()
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int walksFor_a_Day = int.Parse(Console.ReadLine());
            int eatenCalories = int.Parse(Console.ReadLine());
            double formula1 = minutesWalking * walksFor_a_Day;
            double caloriesFire = formula1 * 5;
            double formula3 = 50.0 / 100 * eatenCalories;
            bool isYourCatEnough = (formula3 < caloriesFire)
                && minutesWalking >= 1
                && minutesWalking <= 50
                && walksFor_a_Day >= 1
                && walksFor_a_Day <= 10
                && eatenCalories >= 100
                && eatenCalories <= 40000;
            if (isYourCatEnough)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesFire}. ");
            }
            else if (caloriesFire <= 50.0 / 10 * eatenCalories)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesFire}.");
            }
        }
        static void Task3()
        {


            double cordinateX1 = double.Parse(Console.ReadLine());
            double cordinateY1 = double.Parse(Console.ReadLine());
            double cordinateX2 = double.Parse(Console.ReadLine());
            double cordinateY2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x == cordinateX1 || x == cordinateX2) && (y >= cordinateY1 && y <= cordinateY2))
            {
                Console.WriteLine("Border");
            }
            else if ((y == cordinateY1 || y == cordinateY2) && (x >= cordinateX1 && x <= cordinateX2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }

        static void Task4()
        {
            int group = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kilimnjaro = 0;
            int k2Count = 0;
            int everest = 0;
            int total = 0;

            for (int i = 0; i < group; i++)
            {
                int groupSize = int.Parse(Console.ReadLine());

                if (groupSize <= 5)
                {
                    musala += groupSize;
                }
                else if (groupSize <= 12)
                {
                    monblan += groupSize;
                }
                else if (groupSize <= 25)
                {
                    kilimnjaro += groupSize;
                }
                else if (groupSize <= 40)
                {
                    k2Count += groupSize;
                }
                else
                {
                    everest += groupSize;
                }

                total += groupSize;
            }

            double musalaPercentage = (musala / (double)total) * 100;
            double monblanPercentage = (monblan / (double)total) * 100;
            double kilimanjaroPercentage = (kilimnjaro / (double)total) * 100;
            double k2Percentage = (k2Count / (double)total) * 100;
            double everestPercentage = (everest / (double)total) * 100;

            Console.WriteLine($"{musalaPercentage:f2}%");
            Console.WriteLine($"{monblanPercentage:f2}%");
            Console.WriteLine($"{kilimanjaroPercentage:f2}%");
            Console.WriteLine($"{k2Percentage:f2}%");
            Console.WriteLine($"{everestPercentage:f2}%");
        }
        static void Task5()
        {
            double space = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int loaded = 0;

            while (input != "End")
            {
                double suitcaseVolume = double.Parse(input);
                if (loaded % 3 == 2)
                {
                    suitcaseVolume *= 1.1;
                }

                if (suitcaseVolume > space)
                {
                    Console.WriteLine("No more space!");
                    break;
                }

                space -= suitcaseVolume;
                loaded++;
                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {loaded} suitcases loaded.");
        }

        static void Task6()
        {

        }
    }

}
