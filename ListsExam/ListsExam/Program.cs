namespace ListsExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            Calculations(n, names);
        }

        static void Calculations(int n, List<string> names)
        {
           for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
           names.Sort();
           

            for(int i = 0; i < n;i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}