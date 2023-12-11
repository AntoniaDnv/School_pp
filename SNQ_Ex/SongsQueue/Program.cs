namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ")
                .ToArray();
          Queue<string> playlist = new Queue<string>(songs);


            while (playlist.Count > 0)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                switch (command[0].ToLower())
                {
                    case "play":
                        playlist.Dequeue();
                        break;

                    case "add":
                        command.RemoveAt(0);
                        if (playlist.Contains(string.Join(" ", command)))
                        {
                            Console.WriteLine($"{string.Join(" ", command)} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(string.Join(" ", command));
                        }
                        break;
                    case "show":
                        Console.WriteLine(String.Join(", ", playlist));
                        break;
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}