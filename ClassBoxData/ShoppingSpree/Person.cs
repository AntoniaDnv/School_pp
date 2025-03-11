using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
       private decimal money;
       private List<Product> bagOfProducts;

        public Person(string name, decimal money) 
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {   
                  throw new ArgumentNullException("Name cannot be empty.");
                }
                name = value;
            }
        }
        public decimal Money { get { return money; } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Money cannot be negative.");
                }
                money = value;
            } 
        }

        public IReadOnlyCollection<Product> BagOfProducts { get { return bagOfProducts; } }

        public void AddProduct(Product product)
        {
            if(product.Cost > Money)
            {
                throw new Exception($"{Name} can't afford {product}");
            }
            Money -= product.Cost;
            bagOfProducts.Add(product);
        }



    }
}
