using System;
using System.Collections.Generic;
using System.Linq;

namespace First_and_Reserve_Team
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = 5;

            var persons = new List<Person>();



            for (int i = 0; i < lines; i++)

            {

                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0],

                cmdArgs[1],

                int.Parse(cmdArgs[2]),

                decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            Team team = new Team("lexicon");
            foreach (Person p in persons)
            {
                team.AddPlayer(p);
               
            }
            
            Console.WriteLine($"first team has {team.FirstTeam.Count} players");
            Console.WriteLine($"first team has {team.ReserveTeam.Count} players");
        }
    }

}
