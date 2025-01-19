using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_vet_clinic
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public string MedicalHistory { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string ImagePath { get; set; }
        public Status AdoptionStatus { get; set; }

        public Dog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            MedicalHistory = medicalHistory;
            Weight = weight;
            Color = color;
            AdoptionStatus = Status.NotAdopted;
        }
    }

}
