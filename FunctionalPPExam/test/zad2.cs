namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, int, bool> func = (s, l) =>
            {
                if (s.Length <= l) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            };

            string[] names = Console.ReadLine()
                .Split()

                .ToArray();

           foreach (string name in names)
           {
                if(func(name, n) == true)
                {
                    Console.WriteLine(name);
                }
            }
           
        }
    }
}