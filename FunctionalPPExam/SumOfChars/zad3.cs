namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            Func<string, int> sum = s =>  s.Select(i => (int)i).Sum();

            string[] names = Console.ReadLine()
                .Split();

           for(int i  = 0; i < names.Length; i++)
           {
              if(sum(names[i]) >= n)
              {
                  Console.WriteLine(names[i]);
                    return;
              }
           }

           


        }
    }
}