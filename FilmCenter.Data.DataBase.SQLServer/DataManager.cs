using System;
using System.Collections.Generic;
using FilmCenter.Data.Business;
using FilmCenter.Data.DataBase.SQLServer.DataProvider;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.DataBase.SQLServer
{
    public class DataManager : IUserManager, IFilmManager
    {
        private readonly IActorProvider _actorProvider;
        private readonly IUserProvider _userProvider;
        private readonly IFilmProvider _filmProvider;
        private readonly IDirectorProvider _directorProvider;
        private readonly IPrizeProvider _prizeProvider;
        public DataManager(IActorProvider actorProvider, IUserProvider userProvider, IFilmProvider filmProvider, IDirectorProvider directorProvider, IPrizeProvider prizeProvider)
        {
            this._actorProvider = actorProvider;
            this._userProvider = userProvider;
            this._filmProvider = filmProvider;
            this._directorProvider = directorProvider;
            this._prizeProvider = prizeProvider;
        }

        public bool Authorization(string Login, string Password)
        {
            throw new NotImplementedException();
        }

        public User CurrentUser { get; set; }
        public IEnumerable<Film> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetAllActors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByPrize(Prize prize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByDirector(Director director)
        {
            throw new NotImplementedException();
        }

        public Film GetFilmByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
