using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    public interface IUserProvider
    {
        bool Authorization(string Login, string Password, SqlConnection connection);
        User CurrentUser { get; set; }
    }
}
