namespace maxLengthofNames
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            Func<string, string> func = (string s) =>
            {
                if (s.Length <= n)
                {
                    list.Add(s);

                }
                return s;

            };

            string[] names = Console.ReadLine()
                .Split()
                .Select(func)
                .ToArray();
       
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}