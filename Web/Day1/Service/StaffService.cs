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
    public class StaffService : IStaffService
    {
        private IStaffRepository staffRepository = new StaffRepository();
        public staff CheckLogin(string user, string password)
        {
            return staffRepository.CheckLogin(user, password);
        }

        public int Create(staff staff)
        {
            return staffRepository.Create(staff);
        }

        public bool Delete(int id)
        {
            return staffRepository.Delete(id);
        }

        public List<staff> GetAll()
        {
            return staffRepository.GetAll();
        }

        public staff GetByID(int id)
        {
            return staffRepository.GetByID(id);
        }

        public bool Update(staff staff)
        {
            return staffRepository.Update(staff);
        }
    }
}
