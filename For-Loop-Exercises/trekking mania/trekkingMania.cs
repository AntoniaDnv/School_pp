
using System;
namespace trekking_mania
{
    internal class trekkingMania
    {
        static void Main(string[] args)
        {
           double groups = double.Parse(Console.ReadLine());
            double allPeople = 0;
            double musala = 0;
            double monblan = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (double i = 0; i < groups; i++)
            {
                double peopleInGroup = double.Parse(Console.ReadLine());
                allPeople = allPeople + peopleInGroup;

                if (peopleInGroup < 6)
                {
                    musala = musala + peopleInGroup;
                }
                else if(peopleInGroup < 13 && peopleInGroup>5) 
                {
                 monblan = monblan + peopleInGroup;
                }
                else if(peopleInGroup < 26 && peopleInGroup > 6)
                {
                    kilimanjaro = kilimanjaro + peopleInGroup;
                }
                else if (peopleInGroup <41 && peopleInGroup > 25)
                {
                    k2 = k2 +peopleInGroup;
                }
                else if (peopleInGroup > 40)
                {
                    everest = everest + peopleInGroup;
                }

                
            }

            double endMusala = musala / allPeople * 100;
            double endMonblan = monblan / allPeople * 100;
            double endMilimanjaro = kilimanjaro / allPeople * 100;
            double endK2 = k2 / allPeople * 100;
            double endeverest = everest / allPeople * 100;
            
            Console.WriteLine($"{endMusala:f2}%");
            Console.WriteLine($"{endMonblan:f2}%");
            Console.WriteLine($"{endMilimanjaro:f2}%");
            Console.WriteLine($"{endK2:f2}%");
            Console.WriteLine($"{endeverest:f2}%");
        }
    }
}