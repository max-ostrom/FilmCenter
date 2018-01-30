using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data.DataBase.SQLServer.Exceptions
{
    public class ConnectionException : Exception
    {
        public ConnectionException()
            : base()
        {

        }
        public ConnectionException(string message)
            : base(message)
        {

        }
        public ConnectionException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
