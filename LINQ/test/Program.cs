namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            Console.WriteLine((int)a);

            string b = "abcdef";
            foreach (char item in b)
            {
                Console.WriteLine((int)item);
            }
        }
    }
}