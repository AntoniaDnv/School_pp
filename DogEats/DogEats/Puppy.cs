using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogEats
{
    public class Puppy : Dog
    {
        private int foodWeight;
        public int FoodWeight
        {
            get => foodWeight;
            set => foodWeight = value;
        }
        public Puppy(string foodType, string breed, int foodWeight) 
            :base(foodType, breed)
        {
            FoodWeight = foodWeight;
        }
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
}
