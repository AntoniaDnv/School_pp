namespace repeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            double m = int.Parse(Console.ReadLine());
            Console.WriteLine(newText(n, m));

            string newText(string n, double m)
            {
                string result = "";
                for( int i  = 0; i < m; i++ )
                {
                    result += n;
                }
                return result;
            }
        }
    }
}