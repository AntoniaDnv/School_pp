﻿using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firtTeam;  
        private List<Person> reserveTeam;

        public Team(string name)
        {
            Name = name;
            firtTeam = new List<Person>();
            reserveTeam = new List<Person>();
    
        }

        public string Name {  get; set; }
        public IReadOnlyCollection<Person> FirtTeam 
        {
            get { return this.firtTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }
        }

        public void AddPlayer(Person person) 
        {
            if (person.Age < 40)
            {
                firtTeam.Add(person);
            }
            else 
            {
             reserveTeam.Add(person);
            }
        }
    }
}
