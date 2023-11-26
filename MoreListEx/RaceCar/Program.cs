namespace RaceCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> time = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            TimeCalculator(time);
        }

        static void TimeCalculator(List<int> time)

        {
            double leftTime = 0;
            double rightTime = 0;
            for (int i = 0; i < (time.Count/2); i++)
            {
                leftTime = leftTime+ time[i];
                if (time[i] == 0)
                {
                    leftTime = leftTime * 0.8;
                }
            }
            for (int i = time.Count; i >= (time.Count / 2)-1; i--)
            {
                rightTime = rightTime + time[i-1];
                if (time[i-1] == 0)
                {
                    rightTime = rightTime * 0.8;
                }
            }
           if(rightTime> leftTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime:f1}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime:f1}");
            }
        }
    }
}