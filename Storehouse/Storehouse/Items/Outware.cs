using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse.Items
{
    public class Outerwear : ClothingItem
    {
        public string Season { get; set; }

        public Outerwear(string name, double price, double weight, string brand, int warrantyYears, string material, string size, string season)
            : base(name, price, weight, brand, warrantyYears, material, size)
        {
            Season = season;
        }
    }
}
