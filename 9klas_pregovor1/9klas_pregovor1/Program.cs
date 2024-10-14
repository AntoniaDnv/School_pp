namespace _9klas_pregovor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string name = Console.ReadLine();
         int numAlbums = int.Parse(Console.ReadLine());
         int numSongs = int.Parse(Console.ReadLine());
         double minutes = double.Parse(Console.ReadLine());

         double totalSongTime = minutes + minutes*0.05;
            double totalTime = numAlbums * (numSongs * totalSongTime);
            Console.WriteLine($"Total time needed to listen {name} songs is {Math.Floor(totalTime)} minutes.");
        }
    }
}