using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse.Items
{
    public class Footwear : ClothingItem
    {
        public string ShoeType { get; set; }

        public Footwear(string name, double price, double weight, string brand, int warrantyYears, string material, string size, string shoeType)
            : base(name, price, weight, brand, warrantyYears, material, size)
        {
            ShoeType = shoeType;
        }
    }
}
