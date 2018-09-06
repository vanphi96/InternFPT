using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface IActorRepository
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