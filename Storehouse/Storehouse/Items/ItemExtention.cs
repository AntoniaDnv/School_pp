using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse.Items
{
    public class ItemExtention : Item
    {
        public string Brand { get; set; }
        public int WarrantyYears { get; set; }

        public ItemExtention(string name, double price, double weight, string brand, int warrantyYears)
        :base(name, price, weight)
        { 
             Brand = brand;
             WarrantyYears = warrantyYears;
        }
    }
}
