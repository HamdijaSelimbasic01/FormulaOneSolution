using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Team
    {
        private int id;
        private string name;
        private string fullTeamName;
        private Country country;
        private string powerUnit;
        private string technicalChief;
        private string chassis;
        private Driver firstDriver;
        private Driver secondDriver;

        public Team(int id, string name, string fullTeamName, Country country, string powerUnit, string technicalChief, string chassis, Driver firstDriver, Driver secondDriver)
        {
            this.Id = id;
            this.Name = name;
            this.FullTeamName = fullTeamName;
            this.Country = country;
            this.PowerUnit = powerUnit;
            this.TechnicalChief = technicalChief;
            this.Chassis = chassis;
            this.FirstDriver = firstDriver;
            this.SecondDriver = secondDriver;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string FullTeamName { get => fullTeamName; set => fullTeamName = value; }
        public Country Country { get => country; set => country = value; }
        public string PowerUnit { get => powerUnit; set => powerUnit = value; }
        public string TechnicalChief { get => technicalChief; set => technicalChief = value; }
        public string Chassis { get => chassis; set => chassis = value; }
        public Driver FirstDriver { get => firstDriver; set => firstDriver = value; }
        public Driver SecondDriver { get => secondDriver; set => secondDriver = value; }

        public override string ToString()
        {
            return $"{this.Name} ({this.Country.CountryName})";
        }
    }
}
