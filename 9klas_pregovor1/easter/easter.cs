namespace easter
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double guests = int.Parse(Console.ReadLine());
         double buget = int.Parse(Console.ReadLine());
            double kozunak = 0;
            double expenses = guests * 2 * 0.80 + guests * 3 * 1;
            kozunak = Math.Ceiling(guests / 4);
            expenses = expenses + kozunak * 10;
            if (buget>= expenses)
            {
                buget = buget - expenses;
                Console.WriteLine($"Ivo bought {kozunak} Easter bread, {guests*3} cookies and {guests*2} eggs.");
                Console.WriteLine($"He has {buget:f2} lv. left.");
            }
            else
            {
                buget = (expenses-buget)*-1;
                Console.WriteLine($"Ivo doesn't have enough money.");
                Console.WriteLine($"He needs {buget:f2} lv. more.");
            }
        }
    }
}