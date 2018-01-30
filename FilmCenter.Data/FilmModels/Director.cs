using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data.FilmModels
{
    public sealed class Director
    {
        public Director(int id, string Name, string Surname)
        {
            Id = id;
            this.Name = Name;
            this.Surname = Surname;
        }
        public Director(int id, string Name, string Surname, DateTime birthDay)
        {
            Id = id;
            this.Name = Name;
            this.Surname = Surname;
            this.birthDay = birthDay;
        }
        public int Id;
        public string Name;
        public string Surname;
        public DateTime? birthDay;
    }
}
