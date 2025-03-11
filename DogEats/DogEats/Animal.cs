using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogEats
{
    public class Animal
    {
        private string foodType;

        public string FoodType 
        {
            get=> foodType;
            set => foodType = value; 
        }

        public Animal(string foodType)
        {
            FoodType = foodType;
        }

        public void Eat()
        {
            Console.WriteLine($"Eating {FoodType}");
        }
    }
}
