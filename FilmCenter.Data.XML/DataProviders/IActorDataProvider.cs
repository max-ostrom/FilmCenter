using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FilmCenter.Data.FilmModels;

namespace FilmCenter.Data.XML.DataProviders
{
    public interface IActorDataProvider
    {
        IEnumerable<Actor> GetAllActors(XDocument document);

        Actor GetActorBySurname(string surname, XDocument document);

    }
}
