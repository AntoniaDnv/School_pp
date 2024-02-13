namespace evenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var evenNum = new Dictionary<int, int>();
            var m = 0; 

            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());    
                if (!evenNum.ContainsKey(num))
                {
                    evenNum.Add(num, 1);
                }
                else
                {
                    m = num;
                }
                
            }
            Console.WriteLine(m);
        }
    }
}