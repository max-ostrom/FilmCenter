using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.Business
{
    public interface IFilmManager
    {
        IEnumerable<Film> GetAllFilms();
        IEnumerable<Actor> GetAllActors();
        IEnumerable<Film> GetFilmsByPrize(Prize prize);
        IEnumerable<Film> GetFilmsByDirector(Director director);

        Film GetFilmByName(string Name);
    }
}
