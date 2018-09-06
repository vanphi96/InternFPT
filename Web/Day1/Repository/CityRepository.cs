using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class CityRepository : ICityRepository
    {
        private sakilaDB contex = new sakilaDB();
        public int Create(city city)
        {
            contex.cities.Add(city);
            contex.SaveChanges();
            return city.city_id;
        }
        public city GetByID(int id)
        {
            return contex.cities.FirstOrDefault(x => x.city_id == id);
        }
        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.cities.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public bool Update( city city)
        {
            var current = GetByID(city.city_id);
            if (current != null)
            {
                current.city1 = city.city1;
                current.country = city.country;
                current.country_id = city.country_id;
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public List<city> GetAll()
        {
            return contex.cities.ToList();
        }
    }
}
