using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    internal class FilmProvider : IFilmProvider
    {
        public IEnumerable<Film> GetAllFilms(SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByYear(DateTime year, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public Film GetFilmByName(string name, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByDirector(Director director, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByActor(Actor actor, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByPrize(Prize prize, SqlConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}
