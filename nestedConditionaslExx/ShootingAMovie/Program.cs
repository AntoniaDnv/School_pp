using System;

namespace ShootingAMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sceenes = int.Parse(Console.ReadLine());
            int numberOfSceenes = int.Parse(Console.ReadLine());
            int sceeneTime = int.Parse(Console.ReadLine());
            double neededTime =0;
            double preperation = sceenes * 0.15;
            double timeToSchoot = numberOfSceenes * sceeneTime;
            neededTime = timeToSchoot + preperation;
            if (neededTime > sceenes)
            {
                double more = neededTime - sceenes;
                Console.WriteLine($"Time is up! To complete the movie you need {more} minutes.");
            }
            else if (neededTime < sceenes) 
            {
                double left = sceenes- neededTime;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(left)} minutes left!");
            }
        }
    }
}