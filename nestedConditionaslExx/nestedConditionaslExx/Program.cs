
namespace nestedConditionaslExx
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string name = Console.ReadLine();
        int sesons = int.Parse(Console.ReadLine());
        int episodes = int.Parse(Console.ReadLine());
        double episodeLenght = double.Parse(Console.ReadLine());
        double addLenght = episodeLenght * 0.20;
            double totalLenght = addLenght + episodeLenght;
            double specialTimeEpisode = sesons * 10;
            double totalTime = totalLenght * sesons * episodes + specialTimeEpisode;
            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(totalTime)} minutes.");

        }
    }
}