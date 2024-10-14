using System.Globalization;
using System;

namespace Defining_Simple_Clases_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime dateTime;
            dateTime = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine($"{dateTime.DayOfWeek}");
            
            
        }
    }
}
