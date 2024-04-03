namespace StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] letters = { "S","T","A","R","s","t", "a","r"};
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                foreach(char a in input)
                {
                    if (a == letters)
                    {

                    }
                }
            }
        }
    }
}