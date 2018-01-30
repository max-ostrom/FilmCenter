using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    internal class ActorProvider : IActorProvider
    {
        public IEnumerable<Actor> GetAllActors(SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorBySurname(string surname, SqlConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}
