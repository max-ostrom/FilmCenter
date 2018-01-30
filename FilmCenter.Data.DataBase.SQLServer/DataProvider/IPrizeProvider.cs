using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    public interface IPrizeProvider
    {
        IEnumerable<Prize> GetAllPrizes(SqlConnection connection);
        Prize GetPrizeByName(string name, SqlConnection connection);
    }
}
