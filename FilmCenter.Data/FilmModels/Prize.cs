using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data.FilmModels
{
    public sealed class Prize
    {
        public Prize(int id, string Name)
        {
            Id = id;
            this.Name = Name;
        }
        public Prize(int id, string Name,DateTime date)
        {
            Id = id;
            this.Name = Name;
            this.date = date;
        }
        public int Id;
        public string Name;
        public DateTime? date;
    }
}
