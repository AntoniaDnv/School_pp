using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        private static readonly Dictionary<string, double> FlourModifiers = new()
        {
            { "White", 1.5 },
            { "Wholegrain", 1.0 }
        };

        private static readonly Dictionary<string, double> BakingModifiers = new()
        {
            { "Crispy", 0.9 },
            { "Chewy", 1.1 },
            { "Homemade", 1.0 }
        };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = char.ToUpper(flourType[0]) + flourType.Substring(1).ToLower();
            BakingTechnique = char.ToUpper(bakingTechnique[0]) + bakingTechnique.Substring(1).ToLower();
            Weight = weight;
        }

        public string FlourType
        {
            private get => flourType;
            set
            {
                if (!FlourModifiers.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            private get => bakingTechnique;
            set
            {
                if (!BakingModifiers.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public double Weight
        {
            private get => weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                    
                weight = value;
            }
        }

        public double GetCalories()
        {
            return 2 * weight * FlourModifiers[flourType] * BakingModifiers[bakingTechnique];
        }

    }
}
