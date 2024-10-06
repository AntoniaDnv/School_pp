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

           
        }

        public static double SuccessRate(int speed)
        {
            if (speed >= 1 && speed <= 4)
            {
                return 1;
            }
            else if (speed >= 5 && speed <= 8)
            {
                return 0.9;
            }
            else if (speed == 9)
            {
                return 0.8;
            }
            else if (speed == 0)
            {
                return 0.0;
            }
            else
            {
                return 0.77;
            }
        }
        public static double ProductionRatePerHour(int speed)
        
           =>  speed * 221 * SuccessRate(speed);
    


    }
} 


   
