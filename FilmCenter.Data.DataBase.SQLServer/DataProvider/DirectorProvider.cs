using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    internal class DirectorProvider : IDirectorProvider
    {
        public IEnumerable<Director> GetAllADirectors(SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public Director GetDirectorBySurname(string surname, SqlConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}
