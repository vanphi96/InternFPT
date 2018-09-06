using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface ICustomerRepository
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