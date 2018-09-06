using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class CustomerRepository : ICustomerRepository
    {
        private sakilaDB contex = new sakilaDB();
        public int Create(customer customer)
        {
            contex.customers.Add(customer);
            contex.SaveChanges();
            return customer.customer_id;
        }
        public bool Delete(int id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.customers.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public customer GetByID(int id)
        {
            return contex.customers.FirstOrDefault(x => x.customer_id == id);
        }
        public bool Update(customer customer)
        {
            var current = GetByID(customer.customer_id);
            if (current != null)
            {
                current.active = customer.active;
                current.address = customer.address;
                current.address_id = customer.address_id;
                current.create_date = customer.create_date;
                current.email = customer.email;
                current.first_name = customer.first_name;
                customer.last_name = customer.last_name;
                current.last_update = customer.last_update;
                current.payments = customer.payments;
                current.rentals = customer.rentals;
                current.store = customer.store;
                current.store_id = customer.store_id;
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public List<customer> GetAll()
        {
            // Hiện dánh sách khách hàng có địa chỉ bao gồm chuỗi sau
            var result = from c in contex.customers
                         join a in contex.addresses on c.address_id equals a.address_id
                         where a.address1.Contains("drive")
                         select new { CustomnerName = c.first_name, Address = a.address1 };
           // return result.FirstOrDefault().CustomnerName;

            // cách 2 join
            var result2=  contex.customers.Join(contex.addresses.Where(a=>a.address1.Contains("drive")), c => c.address_id, a => a.address_id, (c, a) => new { CustomnerName = c.first_name, Address = a.address1 });

            return contex.customers.ToList();
        }
        public List<customer> Filter(string address)
        {
            var joinsql = from c in contex.customers
                          join ad in contex.addresses
                          on c.address_id equals ad.address_id
                          where ad.address1.Contains(address)
                          select c;
            var joinlambda = contex.customers.Join(contex.addresses.Where(c => c.address1.Contains(address)), c => c.address_id, a => a.address_id,
                (c, a) => c).OrderBy(c => c.create_date);
            return joinlambda.ToList();
        }
        // dem so luong khach hang trong tung store
        //public StoreCustomerModel Report()
        //{
        //    var obj = (from c in contex.customers
        //               join s in contex.stores on c.store_id equals s.store_id
        //               group s by s.store_id
        //               into g
        //               select new StoreCustomerModel { StoreID = g.Key, Count = g.Count() }).FirstOrDefault();
        //    return obj;
        //}

        public customer CheckLogin(string user, string password)
        {
            return contex.customers.FirstOrDefault(x => x.first_name == user && x.password == password);
        }
    }
}
