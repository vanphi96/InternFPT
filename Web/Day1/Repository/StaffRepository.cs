using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StaffRepository : IStaffRepository
    {
        private sakilaEntities contex = new sakilaEntities();
        public staff CheckLogin(string user, string password)
        {
            return contex.staffs.FirstOrDefault(x => x.username == user && x.password == password);
        }

        public int Create(staff staff)
        {
            contex.staffs.Add(staff);
            contex.SaveChanges();
            return staff.staff_id;
        }

        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.staffs.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }

        public List<staff> GetAll()
        {
            throw new NotImplementedException();
        }

        public staff GetByID(int id)
        {
            return contex.staffs.FirstOrDefault(x => x.staff_id == id);
        }

        public bool Update(staff staff)
        {
            var current = GetByID(staff.staff_id);
            if (current != null)
            {
                current.active = staff.active;
                current.address_id = staff.address_id;
                current.email = staff.email;
                current.first_name = staff.first_name;
                current.last_name = staff.last_name;
                current.last_update = staff.last_update;
                current.password = staff.password;
                current.payments = staff.payments;
                current.picture = staff.picture;
                current.rentals = staff.rentals;
                current.stores = staff.stores;
                current.store_id = staff.store_id;
                current.username = staff.username;
                return contex.SaveChanges()>0;
                 

            }
            return false;

        }
    }
}
