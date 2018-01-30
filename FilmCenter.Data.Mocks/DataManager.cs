
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.Business;
using FilmCenter.Data.DataBase.SQLServer.DataProvider;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.Mocks
{
    public class DataManager : IFilmManager, IUserManager
    {
        private List<Actor> actors;
        private List<Film> films;
        public IEnumerable<Film> GetAllFilms()
        {
            films = new List<Film>();
            films.Add(new Film(1,"Fiml1",DateTime.Now, actors, new Director(1,"DirectorName", "DirectorSurname")));
            films.Add(new Film(2, "Fiml2", DateTime.Now, actors, new Director(1, "DirectorName", "DirectorSurname")));
            films.Add(new Film(3, "Fiml3", DateTime.Now, actors, new Director(1, "DirectorName", "DirectorSurname")));
            films.Add(new Film(4, "Fiml4", DateTime.Now, actors, new Director(1, "DirectorName", "DirectorSurname")));
            films.Add(new Film(5, "Fiml5", DateTime.Now, actors, new Director(1, "DirectorName", "DirectorSurname")));
            films.Add(new Film(6, "Fiml6", DateTime.Now, actors, new Director(1, "DirectorName", "DirectorSurname")));
            films.Add(new Film(7, "Fiml7", DateTime.Now, actors, new Director(1, "DirectorName", "DirectorSurname")));
            films.Add(new Film(8, "Fiml8", DateTime.Now, actors, new Director(1, "DirectorName", "DirectorSurname")));
            return films;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            actors = new List<Actor>();
            actors.Add(new Actor(1,"Brad","Pitt"));
            actors.Add(new Actor(2, "Nicolas", "Pitt"));
            actors.Add(new Actor(3, "Brad", "Pitt"));
            actors.Add(new Actor(4, "Brad", "Pitt"));
            actors.Add(new Actor(5, "Brad", "Pitt"));
            actors.Add(new Actor(6, "Brad", "Pitt"));
            actors.Add(new Actor(7, "Brad", "Pitt"));
            actors.Add(new Actor(8, "Brad", "Pitt"));
            actors.Add(new Actor(9, "Brad", "Pitt"));
            actors.Add(new Actor(10, "Brad", "Pitt"));
            actors.Add(new Actor(11, "Brad", "Pitt"));
            return actors;
        }

        public Film GetFilmByName(string Name)
        {
            return films.Where(b => b.Name == Name).FirstOrDefault();
        }

        public IEnumerable<Film> GetFilmsByDirector(Director director)
        {
            return films.Where(b => b.Director == director);
        }

        public IEnumerable<Film> GetFilmsByPrize(Prize prize)
        {
            return films;
        }

        public bool Authorization(string Login, string Password)
        {
            CurrentUser = new User(1,"admin","admin", "admin", "admin", Permission.High);
            return true;
        }

        public User CurrentUser { get; set; }
    }
}
