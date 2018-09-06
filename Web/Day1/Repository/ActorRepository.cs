using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class ActorRepository : IActorRepository
    {
        private sakilaDB contex = new sakilaDB();
        public int Create(actor actor)
        {
            contex.actors.Add(actor);
            contex.SaveChanges();
            return actor.actor_id;
        }
        public actor GetByID(int id)
        {
            return contex.actors.FirstOrDefault(x => x.actor_id == id);
        }
        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.actors.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public bool Update(actor actor)
        {
            var current = GetByID(actor.actor_id);
            if (current != null)
            {
                current.film_actor = actor.film_actor;
                current.first_name = actor.first_name;
                current.last_name = actor.last_name;
                current.last_update = DateTime.Now;
                current.image = actor.image;
                
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public List<actor> GetAll()
        {
            return contex.actors.ToList();
        }

        public List<actor> FindActor(string name)
        {
            var obj = contex.actors.Where(x => x.first_name.ToLower().Contains(name.ToLower()) || x.last_name.ToLower().Contains(name.ToLower())).ToList();
            return obj;
        }

        public List<actor> GetActorsFilm(int film_id)
        {
            List<film_actor> film_Actors = new List<film_actor>();
            film_Actors = contex.film_actor.Where(x => x.film_id == film_id).ToList();
            List<actor> actors = new List<actor>();
            foreach(var item in film_Actors)
            {
                actors.Add(GetByID(item.actor_id));
            }
            return actors;
        }
    }
}
