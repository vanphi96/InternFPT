using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IStaffRepository
    {
        int Create(staff staff);
        bool Delete(int id);
        List<staff> GetAll();
        staff GetByID(int id);
        bool Update(staff staff);
        staff CheckLogin(string user, string password);
    }
}
