using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;

        private static readonly Dictionary<string, double> ToppingModifiers = new()
        {
            { "Meat", 1.2 },
            { "Veggies", 0.8 },
            { "Cheese", 1.1 },
            { "Sauce", 0.9 }
        };

        public Topping(string type, double weight)
        {
            Type = char.ToUpper(type[0]) + type.Substring(1).ToLower();
            Weight = weight;
        }

        public string Type
        {
            private get => type;
            set
            {
                if (!ToppingModifiers.ContainsKey(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                    
                type = value;
            }
        }

        public double Weight
        {
            private get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public double GetCalories()
        {
            return 2 * weight * ToppingModifiers[type];
        }
    }
}
