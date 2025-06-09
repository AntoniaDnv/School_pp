using GladiatorTournamentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Classes
{
    public class Weapon : Entity, IWeapon
    {
        public Weapon(int id, string name, decimal cost, double powerLevel, int sharpness)
            : base(id, name, cost, powerLevel)
        {
            Sharpness = sharpness;
        }

        public int Sharpness { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} with: Power Level: {PowerLevel}. Cost: {Cost} (Id: {Id} Sharpness: {Sharpness}";
        }
    }
}
