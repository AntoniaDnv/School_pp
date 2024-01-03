namespace WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> worms = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> holes = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));


            int matching = 0;

            while (worms.Count > 0 && holes.Count > 0)
            {
                int currWorm = worms.Pop();
                int currHole = holes.Peek();


                if (currWorm == currHole)
                {
                    matching++;

                    holes.Dequeue();

                }
                else
                {
                    holes.Dequeue();
                    currWorm -= 3;
                    if (currWorm > 0)
                    {
                        worms.Push(currWorm);
                    }

                }

            }
            if (matching > 0)
            {
                Console.WriteLine($"Matches: {matching}");
            }
            else
            {
                Console.WriteLine("There are no matches");
            }

           
            if(worms.Count == matching && matching< 0)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
           else if(worms.Count == 0)
            {

                Console.WriteLine("Worms left: none ");
            }
            else
            {
                Console.WriteLine($"Worms left: {String.Join(", ", worms)}");
            }

            if (holes.Count<= 0)
            {
                Console.WriteLine("Holes left: none ");
            }
            else
            {
                Console.WriteLine($"Holes left:{String.Join(", ", holes)}");
            }
        }
    }
}