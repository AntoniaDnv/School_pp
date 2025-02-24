using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preperation_for_mini_exam
{
    public class Trainer
    {
        private string name;
        private int badges;
        public List<Pockemon> pockemon;

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            pockemon = new List<Pockemon>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
        public List<Pockemon> Pockemon
        {
            get { return pockemon; }
            set { pockemon = value; }
        }
    }
}
