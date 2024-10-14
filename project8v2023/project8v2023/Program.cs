using System.ComponentModel;

namespace project8v2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 1");
            Console.WriteLine("1. Прости пресмятания");
            Console.WriteLine("2. Условни конструкции");
            Console.WriteLine("3. Вложени конструкции");
            Console.WriteLine("4. For цикъл");
            Console.WriteLine("5. While цикъл");
            Console.WriteLine("6. Вложени цикли");
            Console.WriteLine("7. Изход");

            Console.WriteLine("Моля въведете една от изброените опции!");
            int option = int.Parse( Console.ReadLine());


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
                        case 7:
                            Task7();
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
         double rent = double.Parse(Console.ReadLine());
            double cake = 0.2 * rent;
            double drinks = cake - cake * 0.45;
            double animator = rent * 1 / 3;
            double buget = rent + cake + drinks + animator;
            Console.WriteLine(buget);
        
        }
        static void Task2()
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozes = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double prise = double.Parse(Console.ReadLine());

            double allMoney = magnolii * 3.25 + zumbuli * 4 + rozes * 3.50 + cactus * 8;
            double leftMoney = allMoney - allMoney * 0.05;
            
            if (leftMoney >= prise)
            {
                double ostatuk = leftMoney - prise;
                Console.WriteLine($"She is left with {Math.Floor(ostatuk)} leva.");
            }
            else if (leftMoney < prise)
            {
                double ostatuk = prise - leftMoney;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(ostatuk)} leva.");
            }
        }
        static void Task3()
        {
         int junoirs = int.Parse(Console.ReadLine());
         int seniors = int.Parse(Console.ReadLine());
         string trail = Console.ReadLine();
            double allMoney = 0;
         

           
            if ( junoirs + seniors >= 50 )
            {
                switch (trail)
                {
                    case "trail":
                        allMoney = (junoirs * 5.5 + seniors * 7) - 0.25 * (junoirs * 5.5 + seniors * 7);
                        break;
                    case "cross-country":
                        allMoney = (junoirs * 8 + seniors * 9.50) - 0.25 * (junoirs * 8 + seniors * 9.50);
                        break;
                    case "downhill":
                        allMoney = ( junoirs * 12.25 + seniors * 13.75)-0.25* (junoirs * 12.25 + seniors * 13.75);
                        break;
                    case "road":
                        allMoney = (junoirs * 20 + seniors * 21.50)- 0.25* (junoirs * 20 + seniors * 21.50);
                        break;
                }
            }
            else
            {
                switch (trail)
                {
                    case "trail":
                        allMoney = junoirs * 5.5 + seniors * 7;
                        break;
                    case "cross-country":
                        allMoney = junoirs * 8 + seniors * 9.50;
                        break;
                    case "downhill":
                        allMoney = junoirs * 12.25 + seniors * 13.75;
                        break;
                    case "road":
                        allMoney = junoirs * 20 + seniors * 21.50;
                        break;
                }
            }
            double tax = allMoney - allMoney * 0.05;
            Console.WriteLine($"{tax:f}");
           

        }
       static void Task4()
        {
            double inheritance = double.Parse( Console.ReadLine() );    
            double yearToLive = double.Parse( Console.ReadLine() );
            double age = 18;

            for ( int i = 1800; i<=yearToLive; i++)
            {
               
                if (i%2 == 0)
                {
                    inheritance -= 12000;
                }
                else
                {
                  inheritance =  inheritance - (12000 + age * 50);
                }
                age++;
            }
            if (inheritance < 0)
            {
                Console.WriteLine($"He will need {(inheritance * -1):f2} dollars to survive.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:f2} dollars left.");
            }
        }
        static void Task5()
        {
            string letter = Console.ReadLine();
            string word = "";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            double c = 0;
            double n = 0;
            double o = 0;
            
            while (letter != "End")
            {
                switch (letter.ToLower())
               {
                        case "o":
                        o++;
                        break;
                        case "n":
                        n++;
                        break;
                        case "c":
                        c++;
                        break;
               }
                if ((upper.Contains(letter) || lower.Contains(letter)))
                {
                    if ((letter == "c" || letter == "C") && c <= 1)
                    {
                        word = word;
                    }
                    else if ((letter == "o" || letter == "O") && o <= 1)
                    {
                        word = word;
                    }
                    else if ((letter == "n" || letter == "N") && n <= 1)
                    {
                        word = word;
                    }
                    else
                    {
                        word = word + letter;

                    }

                    if (c >= 1 && o >= 1 && n >= 1)
                    {

                        Console.WriteLine(word + " ");
                        c = 0;
                        n = 0;
                        o = 0;
                        word = "";
                    }
                }
                
               
                letter = Console.ReadLine();
            }
         

        }
        static void Task6() // I can not finish this task, because of my lack of understanding.
        {
            double num = double.Parse( Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {

                }   
            }
        }

        static void Task7()
        {
            return;
        }

    }
}