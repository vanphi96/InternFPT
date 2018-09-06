using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class FilmService : IFilmService
    {
        private IFilmRepository filmRepository = new FilmRepository();
        public int Create(film film)
        {
            return filmRepository.Create(film);
        }

        public bool Delete(int id)
        {
            return filmRepository.Delete(id);
        }

        public List<film> FindFilm(string name)
        {
            return filmRepository.FindFilm(name);
        }

        public List<film> GetAll()
        {
            return filmRepository.GetAll();
        }

        public film GetByID(int id)
        {
            return filmRepository.GetByID(id);
        }

        public List<film> GetFilmActor(int actor_id)
        {
            return filmRepository.GetFilmActor(actor_id);
        }

        public List<film> GetFilmCategory(int film_id)
        {
            return filmRepository.GetFilmCategory(film_id);
        }

        public IQueryable<film> GetPage(string name, int page, int pagesize)
        {
            return filmRepository.GetPage(name, page, pagesize);
        }

        public int Rating(int film_id)
        {
            return filmRepository.Rating(film_id);
        }

        public bool Update(film film)
        {
            return filmRepository.Update(film);
        }
    }
}
