using Storehouse.Enums;

namespace Storehouse.Items
{
    public class ElectronicItem : ItemExtention
    {
       
        public ElectronicType Type { get; set; }

        public ElectronicItem(string name, double price, double weight, string brand, int warrantyYears, ElectronicType type)
            :base(name, price, weight, brand, warrantyYears)
        {
            Type = type; 
        }
    }
}
