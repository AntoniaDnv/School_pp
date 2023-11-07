namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());

            GetCharsInBetween (n, m);

        }

        static void GetCharsInBetween(char n, char m)
        {
            char startChar;
            char endChar;

            if (n < m)
            {
                startChar = n;
                endChar = m;
            }
            else
            {
                startChar = m;
                endChar = n;
            }

            for (char i = ++startChar; i < endChar; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
       
    }
}