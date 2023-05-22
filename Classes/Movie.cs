using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    internal class Movie
    {
        private int idMovie;
        private string name;
        private string type;
        private DateTime duration;
        private int actorId;

     
        public Movie(int idMovie, string name, string type, DateTime duration, int actorId)
        {
            this.idMovie = idMovie;
            this.name = name;
            this.type = type;
            this.duration = duration;
            this.actorId = actorId;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public DateTime Duration { get => duration; set => duration = value; }
        public int ActorId { get => actorId; set => actorId = value; }
    }
}
