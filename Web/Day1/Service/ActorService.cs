using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class ActorService : IActorService
    {
        public IActorRepository actorRepository = new ActorRepository();
        public int Create(actor actor)
        {
            return actorRepository.Create(actor);
        }

        public bool Delete(int id)
        {
            return actorRepository.Delete(id);
        }

        public List<actor> FindActor(string name)
        {
            return actorRepository.FindActor(name);
        }

        public List<actor> GetActorsFilm(int film_id)
        {
            return actorRepository.GetActorsFilm(film_id);
        }

        public List<actor> GetAll()
        {
            return actorRepository.GetAll();
        }

        public actor GetByID(int id)
        {
            return actorRepository.GetByID(id);
        }

        public bool Update(actor actor)
        {
            return actorRepository.Update(actor);
        }
    }
}
