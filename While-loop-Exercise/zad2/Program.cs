using System;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int badGrades = int.Parse(Console.ReadLine());
          
           int problemCounter = 0;
            int badGRCounter = 0;
            int gradeSum = 0;
            int avarage = 0;
            string lastEx = "";
           
            while (true)
            {
                string ex = Console.ReadLine();
              
               
                if (ex == "Enough")
                {
                    avarage = gradeSum / problemCounter;
                    Console.WriteLine($"Average score: {avarage:f2}");
                    Console.WriteLine($"Number of problems: {problemCounter}");
                    Console.WriteLine($"Last problem: {lastEx}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                problemCounter++;
                if (grade <= 4) 
                {
                    badGRCounter++;
                }
                if (badGrades == badGRCounter)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    break;
                }
                lastEx = ex;
                
            }
        }
    }
    
}