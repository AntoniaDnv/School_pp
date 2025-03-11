using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogEats
{
    public class Dog :Animal
    {
        private string breed;

        public string Breed 
        {
            get => breed;
            set=> breed = value; 
        }
        public Dog(string foodType,string breed)
            : base(foodType)
        {
           Breed = breed;
        }
        public void Bark()
        {
            Console.WriteLine($"{Breed} barking");
        }
    }
}
