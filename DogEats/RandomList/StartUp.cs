namespace CustomRandomList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();

            randomList.Add("Gosho");
            randomList.Add("Miri");
            randomList.Add("Presi");

            Console.WriteLine(randomList.RandomString());
        }
    }
}
