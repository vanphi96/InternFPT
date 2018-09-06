using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public interface IFilmService
    {

        int Create(film film);
        bool Delete(int id);
        List<film> GetAll();
        film GetByID(int id);
        bool Update(film film);
        List<film> FindFilm(string name);
        IQueryable<film> GetPage(string name, int page, int pagesize);
        List<film> GetFilmCategory(int film_id);
        List<film> GetFilmActor(int actor_id);
        int Rating(int film_id);
    }
}
