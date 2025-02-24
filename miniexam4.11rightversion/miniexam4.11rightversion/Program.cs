namespace miniexam4._11rightversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateDifferenceCalculator calculator = new DateDifferenceCalculator();

            string date1 = Console.ReadLine();

            string date2 = Console.ReadLine();

            int daysDifference = calculator.CalculateDaysDifference(date1, date2);
            Console.WriteLine($"{daysDifference}");
        }
    }
}
