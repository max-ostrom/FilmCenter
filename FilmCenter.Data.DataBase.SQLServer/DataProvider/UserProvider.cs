using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data.DataBase.SQLServer.DataProvider
{
    internal class UserProvider : IUserProvider
    {
        public bool Authorization(string Login, string Password, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        public User CurrentUser { get; set; }
    }
}
