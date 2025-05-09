using Storehouse.Enums;

namespace Storehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storehouse storehouse = new Storehouse();
            storehouse.AddFoodItem("Apple", 1.2, 0.5, 7);
            storehouse.AddElectronicItem("Laptop", 1200, 2.5, "TechBrand", 2, ElectronicType.Computer);
            storehouse.AddClothingItem("T-Shirt", 25.5, 0.3, 1, "Nike", "Cotton", "L");
            storehouse.AddFootwear("Sneakers", 85.0, 1.2, 1, "Reebok", "Leather", "42", "Running");
            storehouse.AddOuterwear("Winter Jacket", 150.0, 2.0, 1, "North Face", "Polyester", "M", "Winter");

            storehouse.PrintItems();
        }
    }
}
