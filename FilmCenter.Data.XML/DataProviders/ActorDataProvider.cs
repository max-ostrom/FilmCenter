using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.XML.DataProviders
{
    public class ActorDataProvider : IActorDataProvider
    {
        public IEnumerable<Actor> GetAllActors(XDocument document)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorBySurname(string surname, XDocument document)
        {
            throw new NotImplementedException();
        }
    }
}
