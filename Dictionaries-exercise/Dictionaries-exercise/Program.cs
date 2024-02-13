namespace Dictionaries_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string word = Console.ReadLine();
           var count = new Dictionary<char, int>();

           for(int i = 0; i< word.Length; i++)
           {
                if (word[i] == ' ')
                {
                   
                }
                else if(count.ContainsKey(word[i]))
                {
                    count[word[i]]++;
                }
                else
                {
                    count.Add(word[i], 1);
                }
           }

           foreach(var kvp in count)
           {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
           }
        }
    }
}