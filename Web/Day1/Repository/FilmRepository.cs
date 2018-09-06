using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class FilmRepository : IFilmRepository
    {
        private sakilaDB context = new sakilaDB();
        public int Create(film film)
        {
            context.films.Add(film);
            context.SaveChanges();
            return film.film_id;
        }
        public film GetByID(int id)
        {
           return context.films.FirstOrDefault(x => x.film_id == id);
        }
        public bool Update(film film)
        {
            var current = GetByID(film.film_id);
            if (current != null)
            {
                current.film_actor = film.film_actor;
                if (!string.IsNullOrEmpty(film.description))
                {
                    current.description = film.description;
                }
                current.film_category = film.film_category;
                if (!string.IsNullOrEmpty(film.image))
                {
                    current.image = film.image;
                }
                current.inventories = film.inventories;
                current.language = film.language;
                current.language1 = film.language1;
                current.language_id = film.language_id;
                current.last_update = film.last_update;
                current.length = film.length;
                current.original_language_id = film.original_language_id;
                current.rating = film.rating;
                current.release_year = film.release_year;
                current.rental_duration = film.rental_duration;
                current.replacement_cost = film.replacement_cost;
                current.special_features = film.special_features;
                current.title = film.title;
                current.url = film.url;
                return context.SaveChanges() > 0;
            }
            return false;
        }
        public List<film> GetAll()
        {
            return context.films.ToList();
        }
        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                context.films.Remove(delete);
               return context.SaveChanges() > 0;
            }
            return false;
        }

        public List<film> FindFilm(string name)
        {
            return context.films.Where(x => x.title.ToLower().Contains(name.ToLower())).ToList();
        }

        public IQueryable<film> GetPage(string name,int page, int pagesize)
        {
            return context.films.Where(x => x.title.ToLower().Contains(name.ToLower())).Skip((page - 1) * pagesize).Take(pagesize);
        }

        public List<film> GetFilmCategory(int film_id)
        {
            List<film> films = new List<film>();
            var categories = context.film_category.FirstOrDefault(x => x.film_id == film_id);
            if (categories != null)
            {
                var filmcategories = context.film_category.Where(x => x.category_id == categories.category_id).ToList();
                foreach(var item in filmcategories)
                {
                    films.Add(GetByID(item.film_id));
                }
            }
            if (films.Count > 0)
            {
                films.Remove(GetByID(film_id));
            }

            return films;
        }

        public List<film> GetFilmActor(int actor_id)
        {
            List<film> films = new List<film>();
            var filmActors = context.film_actor.Where(x => x.actor_id == actor_id).ToList();
            if (filmActors != null)
            {
                foreach (var item in filmActors)
                {
                    films.Add(GetByID(item.film_id));
                }
            }
            return films;

        }

        public int Rating(int film_id)
        {
            var comments = context.comments.Where(x => x.film_id == film_id).ToList();
            int dem = 0;
            int sum = 0;
            foreach(var item in comments)
            {
                if (item.rating != null)
                {
                    dem++;
                    sum += item.rating.Value;
                }
            }
            if (dem != 0)
            {
                return (int)(sum / dem);
            }
            return 0;
        }
    }
}
