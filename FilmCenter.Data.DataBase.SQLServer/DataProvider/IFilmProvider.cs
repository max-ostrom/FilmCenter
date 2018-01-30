using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    public interface IFilmProvider
    {
        IEnumerable<Film> GetAllFilms(SqlConnection connection );
        IEnumerable<Film> GetFilmsByYear(DateTime year, SqlConnection connection);
        Film GetFilmByName(string name, SqlConnection connection);
        IEnumerable<Film> GetFilmsByDirector(Director director, SqlConnection connection);
        IEnumerable<Film> GetFilmsByActor(Actor actor, SqlConnection connection);
        IEnumerable<Film> GetFilmsByPrize(Prize prize, SqlConnection connection);
    }
}
