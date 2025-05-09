using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storehouse.Items
{
    public class FoodItem :Item
    {
  
        public int ExpirationDays { get; set; }

        public FoodItem(string name, double price, double weight, int expirationDays)
            :base(name, price, weight)
        { 
            ExpirationDays = expirationDays;
        }
    }
}
