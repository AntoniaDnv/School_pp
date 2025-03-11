namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(";");
            string[] products = Console.ReadLine().Split(";");
            List<Person> persons = new List<Person>();
            List<Product> shopping = new List<Product>();
            for (int i = 0; i < products.Length; i++)
            {
                string[] oneProduct = products[i].Split("=");
                string productName = oneProduct[0];
                decimal cost = decimal.Parse(oneProduct[1]);
                Product product = new Product(cost, productName);
                shopping.Add(product);

            }

            for (int i = 0; i < people.Length; i++) 
            {
                string[] onePerson = people[i].Split("=");
                string name = onePerson[0];
                decimal money = decimal.Parse(onePerson[1]);
                Person person = new Person(name, money);
                persons.Add(person);
            }
                
            string[] command = Console.ReadLine().Split();
            while(command[0] != "END")
            {
                string name = command[0];
                string product = command[1];

              int numPerson = persons.FindIndex(x => x.Name == name);
                int productIndex = shopping.FindIndex(x => x.ProductName == product);

                persons[numPerson].AddProduct(shopping[numPerson]);

                command = Console.ReadLine().Split();
            }
        }
    }
}
