using PersonsInfo;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }

            Team team = new Team("SoftUni");
            foreach (var person in persons) 
            {
             team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {persons.FirstTeam.Count} players.");
        }
    }
}
