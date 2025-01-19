using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_vet_clinic
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public string MedicalHistory { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string ImagePath { get; set; }
        public Status AdoptionStatus { get; set; }
    }

}
