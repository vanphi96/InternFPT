using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class AcountRepository : IAcountRepository
    {
        public bool CheckLogin(ref AccountModel account, ref object people)
        {
            ICustomerRepository customer = new CustomerRepository();
            IStaffRepository staff = new StaffRepository();
            if (customer.CheckLogin(account.UserName, account.Password) != null)
            {
                people = customer.CheckLogin(account.UserName, account.Password);
                account.Admin = false;
                return true;
            }
            else if(staff.CheckLogin(account.UserName, account.Password) != null)
            {
                people = staff.CheckLogin(account.UserName, account.Password);
                account.Admin = true;
                return true;
            }
            return false;
        }
    }
}
