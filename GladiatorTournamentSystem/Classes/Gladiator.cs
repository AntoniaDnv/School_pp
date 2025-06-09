using GladiatorTournamentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Classes
{
    public abstract class Gladiator : Entity, IGladiator
    {

        private List<IWeapon> equipment;  
        protected Gladiator(int id, string name, decimal cost, double powerLevel) : base(id, name, cost, powerLevel)
        {
        }
        public override double PowerLevel
        {
            get
            {
                double avargaePowerLevel = equipment.Sum(w => w.PowerLevel) / equipment.Count;
                   return avargaePowerLevel + base.PowerLevel;
            }
        }

        public override decimal Cost
        {
            get
            {
                decimal avarageEquipmentCost = equipment.Sum(w => w.Cost);
                return avarageEquipmentCost + base.Cost;    
            }
        }

        public IReadOnlyCollection<IWeapon> Equipment
        {
            get
            {
                return equipment;
            }
        }

        public void AddWeapon(IWeapon equipment)
        {
            this.equipment.Add(equipment);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Name: {name} with: Power Level: {power level}. Cost: {cost} (Id:{id})")
                .AppendLine($"Weapons ({Equipment.Count})");
            foreach (var weapon in equipment) 
            {
                sb.AppendLine($"     ");
            }
            return "";
        }
    }
}
