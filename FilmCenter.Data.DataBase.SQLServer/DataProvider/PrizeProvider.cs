using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    internal class PrizeProvider : IPrizeProvider
    {
        public IEnumerable<Prize> GetAllPrizes(SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public Prize GetPrizeByName(string name, SqlConnection connection)
        {
            throw new NotImplementedException();
        }
    }
}
