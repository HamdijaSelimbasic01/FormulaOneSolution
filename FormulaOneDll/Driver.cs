using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Driver
    {
        private readonly int id;
        private string firstname;
        private string lastname;
        private DateTime dob;
        private string placeOfBirth;
        private Country country;

        public Driver(int id, string firstname, string lastname, DateTime dob, string placeOfBirth, Country country)
        {
            this.id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Dob = dob;
            this.PlaceOfBirth = placeOfBirth;
            this.Country = country;
        }

        public int Id { get => id; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string PlaceOfBirth { get => placeOfBirth; set => placeOfBirth = value; }
        public Country Country { get => country; set => country = value; }

        public override string ToString()
        {
            string stOut = this.Firstname + " " + this.Lastname;
            return stOut;
        }

    }
}
