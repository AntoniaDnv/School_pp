using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse.Items
{
    public class ClothingItem : ItemExtention
    {
       
        public string Material { get; set; }
        public string Size { get; set; }
     

        public ClothingItem(string name, double price, double weight,string brand,int warrantyYears, string material, string size)
            :base(name, price, weight, brand, warrantyYears)
        {
           Material = material;
            Size = size;
        }
    }
}
