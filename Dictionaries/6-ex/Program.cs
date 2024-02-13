namespace _6_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>();

            string[] input = Console.ReadLine().Split();

            while(input[0] != "buy")
            {
                string product = input[0];
                double pricee = double.Parse(input[1]);
                int qty = int.Parse(input[2]);

                if(products.ContainsKey(product))
                {
                    products[product][0] = pricee;
                    products[product][1] += qty;
                }
                else
                {
                    products.Add(product, new List<double>());
                    products[product].Add(pricee);
                    products[product].Add(qty);
                }

            }
            foreach(var kvp in products)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];

                Console.WriteLine($"{kvp.Key}->{totalPrice}");
            }
        }
    }
}