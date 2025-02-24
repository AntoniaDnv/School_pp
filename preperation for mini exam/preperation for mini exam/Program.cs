namespace preperation_for_mini_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trainers = new Dictionary<string, Trainer>();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Tournament") 
            {
              string trainerName = command[0];
              string pockemonName = command[1];
              string pockemonElement = command[2];
              int pockemonHealth = int.Parse(command[3]);

                if (!trainers.ContainsKey(trainerName)) 
                {
                    trainers[trainerName] = new Trainer(trainerName);
                
                }
                var newPockemon = new Pockemon(pockemonName, pockemonElement, pockemonHealth);
                trainers[trainerName].pockemon.Add(newPockemon);

                command = Console.ReadLine().Split();
            }

            command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string element = command[0];
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.pockemon.Any(p => p.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = trainer.pockemon.Count - 1; i >= 0; i--)
                        {
                            var pockemoni = trainer.pockemon[i];
                            pockemoni.Health -= 10;


                        }
                        trainer.pockemon = trainer.pockemon.Where(p => p.Health > 0).ToList();
                    }
                }
                command = Console.ReadLine().Split();
            }

            var orderedTrainers = trainers.Values.OrderByDescending(t => t.Badges).ThenBy(t => trainers.Keys.ToList().IndexOf(t.Name));
            foreach (var trainer in orderedTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.pockemon.Count}");
            }
        }
    }
}
