using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository, IGenericRepository<Information>
    {
        private IGenericRepository<Information> genericRepository = new GenericRepository<Information>();
         
        public int CheckUser(string email)
        {
            int status = -1;
            var infomations = this.SelectAll().ToList();
            var obj = infomations.Where(x => x.gmail.Equals(email)).FirstOrDefault();
            if (obj != null)
            {
                return obj.admin.Value;
            }

            return status;

        }

        public void Delete(object id)
        {
            genericRepository.Delete(id);
        }

        public void Insert(Information obj)
        {
            genericRepository.Insert(obj);
        }

        public void Save()
        {
            genericRepository.Save();
        }

        public IEnumerable<Information> SelectAll()
        {
            return genericRepository.SelectAll();
        }

        public Information SelectById(object id)
        {
            return genericRepository.SelectById(id);
        }

        public void Update(Information obj)
        {
            genericRepository.Update(obj);
        }
    }
}
