namespace zad3
{
    internal class zad3
    {
        static void Main(string[] args)
        {
            string goEnd = Console.ReadLine();
            while (goEnd == "Go")
            {
                    string one = Console.ReadLine();
                    string two = Console.ReadLine();
                    string three = Console.ReadLine();
                    string end = one+ two + three;
                    Console.WriteLine(end);
                goEnd = Console.ReadLine();
                
            }
        }
    }
}