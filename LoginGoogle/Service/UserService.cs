using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private IUserRepository userService = new UserRepository();
        public int CheckUser(string email)
        {
           return userService.CheckUser(email);
        }
    }
}
