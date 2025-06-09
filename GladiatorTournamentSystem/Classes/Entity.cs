using GladiatorTournamentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTournamentSystem.Classes
{
    public abstract class Entity : IEntity
    {
        private int id;
        public int Id 
        {
            get {  return Id; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("The id is not allowed to be 0 or less.");
                }
                Id = value;
            }
        }
        protected Entity(int id, string name, decimal cost, double powerLevel)
        {
            Id = id;
            Name = name;
            Cost = cost;
            PowerLevel = powerLevel;
            
        }

        public string Name { get; }

        public virtual decimal Cost { get; }

        public virtual double PowerLevel { get; }
        public override string ToString()
        {
            return $"Power level: {PowerLevel}. {Cost}  (Id: {id})";
        }
    }
}
