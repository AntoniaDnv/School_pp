namespace waterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            int sum =  0;
            int ok = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                
                   

                    if (sum + liters >= 255)
                    {
                        sum = sum;
                        Console.WriteLine($"Insufficient capacity!");
                      

                    }
                    if (sum + liters <255)
                    {
                        sum += liters;
                    }
                   
                
               
               

            }
            Console.WriteLine(sum);
        }
    }
}