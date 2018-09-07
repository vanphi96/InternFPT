using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public interface ILoginRepository
    {
        bool Login();
        string Create( information infor);
    }
}
