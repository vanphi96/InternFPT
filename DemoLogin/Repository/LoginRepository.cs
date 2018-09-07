using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class LoginRepository : ILoginRepository
    {
        private loginDB loginDB = new loginDB();
        public string Create(information infor)
        {
            loginDB.information.Add(infor);
            return infor.id;
        }

        public bool Login()
        {
            throw new NotImplementedException();
        }
    }
}
