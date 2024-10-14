using System.ComponentModel;

namespace other1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int ballNumber = int.Parse(Console.ReadLine());
           
           double points = 0;
            int divid = 0;
            int otherColor = 0;
            int redBall = 0;
            int yellowBall = 0;
            int orangeBall = 0;
            int whiteBall = 0;


            for(int i = 0; i < ballNumber; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    points += 5;
                    redBall++;
                }
                else if(color == "orange")
                {
                    points += 10;
                    orangeBall++;
                }
                else if (color == "yellow")
                {
                    points += 15;
                    yellowBall++;
                }
                else if(color == "white")
                {
                    points += 20;
                    whiteBall++;
                }
                else if (color == "black")
                {
                    points = points / 2;
                    divid++;
                }
                else
                {
                    points = points;
                    otherColor++;
                }

                


            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redBall}");
            Console.WriteLine($"Orange balls: {orangeBall}");
            Console.WriteLine($"Yellow balls: {yellowBall}");
            Console.WriteLine($"White balls: {whiteBall}");
            Console.WriteLine($"Other colors picked: {otherColor}");
            Console.WriteLine($"Dividesnfrom black balls: {divid}");


        }
    }
}