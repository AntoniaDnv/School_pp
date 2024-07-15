using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace Lasagna
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var lasagna = new Lasagna();
            int minutesInOven = lasagna.ExpectedMinutesInOven();
            int remainingMinutesInOven = lasagna.RemainingMinutesInOven(30);
            int leyarsTime = lasagna.PreparationTimeInMinutes(2);
            int totalTime = lasagna.ElapsedTimeInMinutes(3, 20);
            Console.WriteLine(totalTime);

        }
            class Lasagna
            {
            public int Test() => 40;
                public int ExpectedMinutesInOven()
                {
                    return 40;
                }
                public int RemainingMinutesInOven(int minutesInOven)
                {
                    int totalMinutes = ExpectedMinutesInOven();
                    return totalMinutes - minutesInOven;
                }
                public int PreparationTimeInMinutes(int leyars)
                {
                    return leyars * 2;
                }
                public int ElapsedTimeInMinutes(int leyarsTime, int minutesSpentInOven)
                {
                    return leyarsTime + minutesSpentInOven;
                }
            public static string Message(string logLine)
            {
                string[] fuckU = logLine.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                char[] charsToTrim = { '[', ']' };
               
                return fuckU[0].ToLower().Trim();
            }
        }
    }
} 


   
