using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IAcountRepository
    {
        bool CheckLogin(ref AccountModel account, ref Object people);
    }
}
