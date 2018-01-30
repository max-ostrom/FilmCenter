using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    public interface IDirectorProvider
    {
        IEnumerable<Director> GetAllADirectors(SqlConnection connection);
        Director GetDirectorBySurname(string surname, SqlConnection connection);
    }
}
