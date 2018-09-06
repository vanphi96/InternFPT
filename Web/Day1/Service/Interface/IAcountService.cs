using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
   public interface IAcountService
    {
        bool CheckLogin(ref AccountModel account, ref Object people);
    }
}
