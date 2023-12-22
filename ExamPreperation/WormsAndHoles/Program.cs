using System.Diagnostics.Metrics;

namespace WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] worms = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int[] holes   = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            Stack<int> worm = new Stack<int>(worms);
            Stack<int> hole = new Stack<int>(holes);

            for(int i = 0; i < hole.Count * 2 && i < worm.Count * 2; i++)
            {
                if (worms[worms.Length-i-1] == holes[i])
                {
                    hole.Pop();
                    worm.Pop();
                    counter++;
                }
                else
                {
                    if(worms[worms.Length - i - 1] <= 0)
                    {
                        i++;
                    }
                    else
                    {
                        hole.Pop();
                        
                        while (worms[worms.Length - i - 1] > 0)
                        {
                            worms[worms.Length - i - 1] = worms[worms.Length - i - 1] - 3;

                            if (worms[worms.Length - i - 1] == holes[i])
                            {
                                hole.Pop();
                                worm.Pop();
                                counter++;
                            }
                        }
                        
                    }
                   
                        
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"Matches: {counter}");
            }
            else
            {
                Console.WriteLine("There are no matches.");
            }

            if(worm.Count == 0)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }

        }
    }
}