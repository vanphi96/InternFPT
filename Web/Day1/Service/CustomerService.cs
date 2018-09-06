using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository = new CustomerRepository();

        public customer CheckLogin(string user, string password)
        {
            return customerRepository.CheckLogin(user, password);
        }

        public int Create(customer customer)
        {
            return customerRepository.Create(customer);
        }

        public bool Delete(int id)
        {
            return customerRepository.Delete(id);
        }

        public List<customer> Filter(string address)
        {
            return customerRepository.Filter(address);
        }

        public List<customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public customer GetByID(int id)
        {
            return customerRepository.GetByID(id);
        }
        

        public bool Update(customer customer)
        {
            return customerRepository.Update(customer);
        }
    }
}
