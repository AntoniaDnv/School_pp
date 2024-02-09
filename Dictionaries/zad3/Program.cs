namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonim = new Dictionary<string, List<string>>();
           for(int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();  
                string syn = Console.ReadLine();
                if(synonim.ContainsKey(word))
                {
                    synonim[word].Add(syn);

                }
                else
                {
                    synonim.Add(word, new List<string>());
                    synonim[word].Add(syn);
                }
               
            }
            foreach (var kvp in synonim)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(" , " ,kvp.Value)}");
            }
        }
    }
}