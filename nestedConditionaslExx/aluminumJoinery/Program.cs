using System.Runtime.CompilerServices;

namespace aluminumJoinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joinery = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string delivery = Console.ReadLine();
            double joineryPrice = 0;
            double totalPrice = 0;
            double endPrice = 0;
            double joineryX = 0;


            

            switch (size)
            {
                case "90X130":
                    joineryX = 110*joinery;
                    if (joinery > 30 && joinery <60)
                    {
                        joineryPrice = joineryX - joineryX* 0.05;
                    }
                    else if (joinery > 60)
                    {
                        joineryPrice = joineryX - joineryX  * 0.08;
                    }
                    
                    break;
                case "100X150":
                    joineryX = 140 * joinery;
                    if (joinery > 40 && joinery <80)
                    {
                        joineryPrice = joineryX - joineryX * 0.06;
                    }
                    else if (joinery > 80)
                    {
                        joineryPrice = joineryX - joineryX  * 0.1;
                    }
                    break;
                case "130X180":
                    joineryX = 190 * joinery;
                    if (joinery > 20 && joinery <50)
                    {
                        joineryPrice = joineryX - joineryX * 0.07;
                    }
                    else if (joinery > 50)
                    {
                        joineryPrice = joineryX - joineryX * 0.12;
                    }
                    break;
                case "200X300":
                    joineryX = 250*joinery;
                    if (joinery > 25 && joinery <50)
                    {
                        joineryPrice = joineryX - joineryX * 0.09;
                    }
                    else if (joinery > 50)
                    {
                        joineryPrice = joineryX - joineryX * 0.14;
                    }
                    break;

            }
            if (delivery == "With delivery")
            {
                totalPrice = joineryPrice + 60;
            }
            else if (delivery == "Without delivery")
            {
                totalPrice = joineryPrice;
            }
                

            if (joinery > 99)
            {
                endPrice = totalPrice - 0.04 * totalPrice;
            }
            else
            {
                endPrice = totalPrice;
            }

            if (joinery < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else if (joinery >= 10)
            {
                Console.WriteLine($"{endPrice:F2} BGN");
            }


           
        }
    }
}