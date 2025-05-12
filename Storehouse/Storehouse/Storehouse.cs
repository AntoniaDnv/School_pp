using Storehouse.Enums;
using Storehouse.Items;

namespace Storehouse
{
    public class Storehouse
    {
       
      
        private List<FoodItem> foodItems = new List<FoodItem>();
        private List<ElectronicItem> electronics = new();
        private List<ClothingItem> clothingItems = new();
        private List<Footwear> shoes = new();
        private List<Outerwear> outwares = new();

        public void AddFoodItem(string name, double price, double weight, int expirationDays)
        {
            foodItems.Add(new FoodItem(name, price, weight, expirationDays));
        }

        public void AddElectronicItem(string name, double price, double weight, string brand, int warrantyYears, ElectronicType type)
        {
            electronics.Add(new ElectronicItem(name, price, weight, brand, warrantyYears, type));
        }

        public void AddClothingItem(string name, double price, double weight, int warrantyYears, string brand, string material, string size)
        {
            clothingItems.Add(new ClothingItem(name, price, weight, brand, warrantyYears, material, size));
        }

        public void AddFootwear(string name, double price, double weight, int warrantyYears, string brand, string material, string size, string shoeType)
        {
            shoes.Add(new Footwear(name, price, weight, brand, warrantyYears, material, size, shoeType));
        }

        public void AddOuterwear(string name, double price, double weight, int warrantyYears, string brand, string material, string size, string season)
        {
            outwares.Add(new Outerwear(name, price, weight, brand, warrantyYears, material, size, season));
        }
            
        public void PrintItems()
        {
            foreach (var item in foodItems)
            {
                Console.WriteLine($"{item.Name} - {item.Price:f2}$ - {item.Weight}kg - Expires in {item.ExpirationDays} days");
            }
            foreach (var item in electronics)
            {
                Console.WriteLine($"{item.Name} - {item.Price:f2}$ - {item.Weight}kg - {item.Brand} - {item.WarrantyYears} - Type: {item.Type}");
            }
            foreach (var item in clothingItems)
            {
                Console.WriteLine($"{item.Name} - {item.Price:f2}$ - {item.Weight}kg - {item.Brand} - {item.WarrantyYears} - Material: {item.Material} - Size: {item.Size}");
            }
            foreach (var item in shoes)
            {
                Console.WriteLine($"{item.Name} - {item.Price:f2}$ - {item.Weight}kg - {item.Brand} - {item.WarrantyYears} - Material: {item.Material} - Size: {item.Size} - Type: {item.ShoeType}");
            }
            foreach (var item in outwares)
            {
                Console.WriteLine($"{item.Name} - {item.Price:f2}$ - {item.Weight}kg - {item.Brand} - {item.WarrantyYears} - Material: {item.Material} - Size: {item.Size} - Season: {item.Season}");
            }
        }
    }
}
