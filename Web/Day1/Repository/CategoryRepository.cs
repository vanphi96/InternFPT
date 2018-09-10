using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository.Interface;
namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {       
        private sakilaDB contex = new sakilaDB();
        public byte Create(category category)
        {
            contex.categories.Add(category);
            contex.SaveChanges();
            return category.category_id;
            
        }

        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.categories.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }

        public List<category> GetAll()
        {
            return contex.categories.ToList();
        }

        public category GetByID(int id)
        {
            return contex.categories.FirstOrDefault(x => x.category_id == id);
        }

        public bool Update(category category)
        {
            var current = GetByID(category.category_id);
            if (current != null)
            {
                current.name = category.name;
                current.last_update = category.last_update;
                return contex.SaveChanges() > 0;
            }
            return false;
        }
    }
}
