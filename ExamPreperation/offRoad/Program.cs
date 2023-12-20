namespace offRoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initalFuel = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] consumption = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] needed = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> reachedAltitudes = new List<int>();
            for (int i = 0; i < needed.Length; i++)
            {
                if (initalFuel[initalFuel.Length - i-1] >= consumption[i])
                {
                    int leftFuel;
                    leftFuel = initalFuel[initalFuel.Length - i-1] - consumption[i];
                    if (leftFuel > needed[i])
                    {
                        Console.WriteLine($"John has reached: Altitude {i+1}");
                        reachedAltitudes.Add(i+1);
                    }
                    else
                    {
                        Console.WriteLine($"John did not reach: Altitude {i + 1}");
                        Console.WriteLine($"John failed to reach the top.");
                        Console.WriteLine($"Reached altitudes: {string.Join(" ","Altitude", reachedAltitudes)}");
                        return;
                    }
                }
            }
        }
    }
}