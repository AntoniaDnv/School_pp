using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse.Items
{
    public class Item
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }

        public Item(string name, double price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

    }
}
