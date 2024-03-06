    using System.ComponentModel;

    namespace classification
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                var contest = new Dictionary<string, string>();
                var submitionsPoints = new Dictionary<string, SortedDictionary<string, int>>();
                int totalPoints = 0;
                int maxPoints = int.MinValue;
                string personWithMaxPoints = "";

                string[] input = Console.ReadLine()
                    .Split(":",  StringSplitOptions.RemoveEmptyEntries);
                while (!(input[0] == "the contests are ended"))
                {
                    contest.Add(input[0], input[1]);
                    input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                }
                while (!( input[0] == "the submissions are ended"))
                {
                
               
                    input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                   

                    if (contest.ContainsKey(input[0]))
                    {
                        if (contest.ContainsValue(input[1]))
                        {
                            if (!submitionsPoints.ContainsKey(input[2]))
                            {
                                submitionsPoints.Add(input[2], new SortedDictionary<string, int>());
                                submitionsPoints[input[2]].Add(input[0], int.Parse(input[3]));
                            }
                            else if (submitionsPoints.ContainsKey(input[2]))
                            {
                                if (!submitionsPoints[input[2]].ContainsKey(input[0]))
                                {
                                    submitionsPoints[input[2]].Add(input[0], int.Parse(input[3]));
                                }
                                else if (submitionsPoints[input[2]].ContainsKey(input[0]))
                                {
                                        
                                }
                            
                            }
                        }
                    }
                }
                foreach (var kvp in submitionsPoints)
                {
               
                    foreach (var kvp2 in kvp.Value)
                    {
                        totalPoints = kvp2.Value + totalPoints;
                    }
                    if (totalPoints > maxPoints)
                    {
                        maxPoints = totalPoints;
                        personWithMaxPoints = kvp.Key;
                    }
                    totalPoints = 0;
                }
                Console.WriteLine($"Candidate number one is {personWithMaxPoints} with total {maxPoints} points.");
                Console.WriteLine("Ranking: ");
                foreach (var kvp in submitionsPoints.OrderBy(kvp =>kvp.Key))
                {
                    Console.WriteLine(kvp.Key);

                    foreach(var kvp2 in kvp.Value.OrderByDescending(v => v.Value))
                    {
                        Console.WriteLine($"#  {kvp2.Key} -> { kvp2.Value}");
                    }
                }

            }
            //.orderbydescending(kvp => kvp.value)
        }
    }