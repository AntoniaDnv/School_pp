namespace IteratorAndComperator
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Collection collection = new Collection();

            collection.Add("One", 0);
            collection.Add("Two", 1);
            collection.Add("Three", 2);
            collection.Add("Four", 3);

            foreach (var item in collection) 
            {
             Console.WriteLine(item.ToString());
            }
        }
    }
}
