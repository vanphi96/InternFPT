using Model;
using Repository;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository = new CategoryRepository();
        public byte Create(category category)
        {
            return categoryRepository.Create(category);
        }

        public bool Delete(int id)
        {
            return categoryRepository.Delete(id);
        }

        public List<category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public category GetByID(int id)
        {
            return categoryRepository.GetByID(id);
        }

        public bool Update(category category)
        {
            return categoryRepository.Update(category);
        }
    }
}
