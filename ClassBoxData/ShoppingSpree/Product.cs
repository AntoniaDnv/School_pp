using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Product
    {
        private decimal cost;
        private string productName;

        public Product(decimal cost, string productName)
        {
            Cost = cost;
            ProductName = productName;
        }

        public decimal Cost {  get { return cost; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Money cannot be negative.");
                }
                cost = value;
            }
        }
        public string ProductName { get { return productName; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                productName = value;
            }
        }
    }
}
