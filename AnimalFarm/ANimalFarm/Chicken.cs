using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANimalFarm
{
    public class Chicken
    {
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                age = value;
            }
        }

        public double ProductPerDay
        {
            get { return this.CalculateProductPerDay(); }
        }

        private double CalculateProductPerDay()
        {
            if (Age < 6) return 2;
            if (Age < 12) return 1;
            return 0.75;
        }

        public override string ToString()
        {
            return $"Chicken {Name} (age {Age}) can produce {ProductPerDay} eggs per day.";
        }
    }
}
