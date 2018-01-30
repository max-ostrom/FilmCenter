using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data.Business
{
    public interface IUserManager
    {
        bool Authorization(string Login, string Password);
        User CurrentUser { get; set; }
    }
}
