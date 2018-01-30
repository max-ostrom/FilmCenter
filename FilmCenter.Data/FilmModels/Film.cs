using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data.FilmModels
{
    public sealed class Film
    {
        public Film(int id, string Name, DateTime dateOfPublish, IEnumerable<Actor> actors, Director director, IEnumerable<Prize> prizes, string VideoTrailerPath, string ImagePath)
        {
            Id = id;
            this.Name = Name;
            this.dateOfPublish = dateOfPublish;
            Actors = actors;
            Director = director;
            Prizes = prizes;
            this.VideoTrailerPath = VideoTrailerPath;
            this.ImagePath = ImagePath;
        }
        public Film(int id, string Name, DateTime dateOfPublish, IEnumerable<Actor> actors, Director director, IEnumerable<Prize> prizes)
        {
            Id = id;
            this.Name = Name;
            this.dateOfPublish = dateOfPublish;
            Actors = actors;
            Director = director;
            Prizes = prizes;
            this.VideoTrailerPath = "";
            this.ImagePath = "";
        }
        public Film(int id, string Name, DateTime dateOfPublish, IEnumerable<Actor> actors, Director director)
        {
            Id = id;
            this.Name = Name;
            this.dateOfPublish = dateOfPublish;
            Actors = actors;
            Director = director;
            Prizes = new List<Prize>();
            this.VideoTrailerPath = "";
            this.ImagePath = "";
        }
        public int Id;
        public string Name;
        public DateTime? dateOfPublish;
        public IEnumerable<Actor> Actors;
        public Director Director;
        public IEnumerable<Prize> Prizes;
        public string VideoTrailerPath;
        public string ImagePath;
    }
}
