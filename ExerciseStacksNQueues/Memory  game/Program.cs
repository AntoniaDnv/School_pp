namespace Memory__game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                .Select(int.Parse)
                .ToArray();
                ;
            int command = int.Parse(Console.ReadLine());
            while (command != "end")
            {

            }
        }
    }
}