using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    public interface IActorProvider
    {
        IEnumerable<Actor> GetAllActors(SqlConnection connection);
        Actor GetActorBySurname(string surname, SqlConnection connection);
    }
}
