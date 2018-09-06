using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface IFilmRepository
    {
        int Create(film film);
        bool Delete(int id);
        List<film> GetAll();
        film GetByID(int id);
        bool Update(film film);
    }
}