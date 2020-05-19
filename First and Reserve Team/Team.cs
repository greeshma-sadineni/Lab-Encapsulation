using System;
using System.Collections.Generic;
using System.Text;

namespace First_and_Reserve_Team
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            this.name = name;
        }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get {return this.firstTeam; }
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
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
    

