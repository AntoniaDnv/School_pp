namespace LettersChangeNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] calculations = Console.ReadLine().Split();
            int result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUNVWXYZ";
            foreach (string calculation in calculations)
            {
                if (calculation[0] == calculation.ToLower()[0])
                {
                    alphabet.IndexOf(calculations[0]);
                }
            }
        }
        static int getNums(string calculation)
        {
            int result = 0;
            foreach(char c in calculation) 
            {
                if (c.IsDigit)
                {

                }
            }

        }
    }
}