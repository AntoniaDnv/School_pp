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
        private List<Person> firstTeam;  
        private List<Person> reserveTeam;

        public Team(string name)
        {
            Name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
    
        }

        public string Name {  get; set; }
        public IReadOnlyCollection<Person> FirtTeam 
        {
            get { return this.firstTeam.AsReadOnly(); }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }
        }

        public void AddPlayer(Person person) 
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else 
            {
             reserveTeam.Add(person);
            }
        }
    }
}
