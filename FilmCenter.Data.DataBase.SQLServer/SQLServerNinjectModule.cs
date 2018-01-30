using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmCenter.Data.Business;
using FilmCenter.Data.DataBase.SQLServer.DataProvider;
using Ninject.Modules;

namespace FilmCenter.Data.DataBase.SQLServer
{
    public sealed class SQLServerDataNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IActorProvider>().To<ActorProvider>().InSingletonScope();
            Bind<IUserProvider>().To<UserProvider>().InSingletonScope();
            Bind<IFilmProvider>().To<FilmProvider>().InSingletonScope();
            Bind<IDirectorProvider>().To<DirectorProvider>().InSingletonScope();
            Bind<IPrizeProvider>().To<PrizeProvider>().InSingletonScope();

            Bind<IFilmManager>().To<DataManager>().InSingletonScope();
            Bind<IUserManager>().To<DataManager>().InSingletonScope();
        }
    }
}
