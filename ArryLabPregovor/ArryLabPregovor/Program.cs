namespace ArryLabPregovor
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int n = int.Parse(Console.ReadLine());
            int sum = 0;
            string line = "";
            for(int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine()); 
                
                line = line + people + " ";
                
                sum += people;
            }
            
            
            Console.WriteLine(line);
            Console.WriteLine(sum);
        }
    }
}