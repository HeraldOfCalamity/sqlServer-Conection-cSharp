using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Actor
    {
        private int id;
        private string? name;
        private string? lastName;
        private char gender;
        private DateTime date;

        public Actor(string name, string lastName, char gender, DateTime date)
        {
            this.name = name;
            this.lastName = lastName;
            this.gender = gender;
            this.date = date;
        }
        public Actor() { }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public char Gender { get => gender; set => gender = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Id { get => id; set => id = value; }
    }
}
