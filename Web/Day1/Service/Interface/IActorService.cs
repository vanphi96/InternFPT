using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IActorService
    {
        int Create(actor actor);
        bool Delete(int id);
        List<actor> FindActor(string name);
        List<actor> GetAll();
        actor GetByID(int id);
        bool Update(actor actor);
        List<actor> GetActorsFilm(int film_id);
    }
}
