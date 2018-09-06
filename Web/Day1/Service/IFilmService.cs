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
    }
}
