using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCenter.Data
{
    public sealed class User
    {
        public  User(int id, string Login, string Password)
        {
            Id = id;
            this.Login = Login;
            this._password = Password;
            this.Name = Login;
            this.Surname = "";
            Permission = Permission.Low;
        }
        public User(int id, string Login, string Password, string Name, string Surname)
        {
            Id = id;
            this.Login = Login;
            this._password = Password;
            this.Name = Name;
            this.Surname = Surname;
            Permission = Permission.Low;
        }
        public User(int id, string Login, string Password, string Name, string Surname, Permission permission)
        {
            Id = id;
            this.Login = Login;
            this._password = Password;
            this.Name = Name;
            this.Surname = Surname;
            Permission = permission;
        }
        public int Id;

        public string Login;

        public string Name;

        public string Surname;

        public Permission Permission;

        public bool isPasswordValid(string password)
        {
            return password == _password;
        }

        private string _password;

    }
}
