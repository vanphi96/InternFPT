using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public interface ICustomerService
    {
        int Create(customer customer);
        bool Delete(int id);
        List<customer> Filter(string address);
        List<customer> GetAll();
        customer GetByID(int id);
        bool Update(customer customer);
        customer CheckLogin(string user, string password);
    }
}
