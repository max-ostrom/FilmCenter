using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FilmCenter.Data.Business;
using FilmCenter.Data.FilmModels;
using FilmCenter.Data.XML.DataProviders;

namespace FilmCenter.Data.XML
{
    public class DataManager : IUserManager, IFilmManager
    {
        private XDocument document;
        private IActorDataProvider actorDataProvider;
        private IDirectorDataProvider directorDataProvider;
        private IFilmDataProvider filmDataProvider;
        private IUserDataProvider userDataProvider;
        private IPrizeDataProvider prizeDataProvider;

        public DataManager(
            IActorDataProvider actorDataProvider,
            IDirectorDataProvider directorDataProvider,
            IFilmDataProvider filmDataProvider,
            IUserDataProvider userDataProvider,
            IPrizeDataProvider prizeDataProvider,
            string xmlPath = "file.xml")
        {
            document = XDocument.Load(xmlPath);
            this.actorDataProvider = actorDataProvider;
            this.directorDataProvider = directorDataProvider;
            this.filmDataProvider = filmDataProvider;
            this.userDataProvider = userDataProvider;
            this.prizeDataProvider = prizeDataProvider;
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

        public Film GetFilmByName(string Name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByDirector(Director director)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetFilmsByPrize(Prize prize)
        {
            throw new NotImplementedException();
        }
    }
}
