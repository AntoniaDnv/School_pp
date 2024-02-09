namespace _6_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            var supermarket = new SortedDictionary<string, Dictionary<string, double>>();

            while (input[0]  != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);
                if(supermarket.ContainsKey(shop)) 
                {
                    
                }
                else
                {
                    supermarket.Add(shop, new Dictionary<string, double>());
                    supermarket[shop].Add(product, price);
                }
                input = Console.ReadLine().Split(", ");

            }
            foreach (var kvp in supermarket)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach( var kvp2 in kvp.Value )
                {

                }
            }
        }
    }
}