using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_vet_clinic
{
 

    public static class StartUp
    {
        public static List<IAnimal> GetInitialAnimals()
        {
            return new List<IAnimal>
        {
            new Cat("Whiskers", DateTime.Now.AddYears(-2), "Persian", "Healthy", 4.5, "White", "Mouse Toy", "cat1.png"),
            new Dog("Buddy", DateTime.Now.AddYears(-3), "Labrador", "Vaccinated", 20.0, "Golden", "dog1.png")
        };
        }
    }

}
