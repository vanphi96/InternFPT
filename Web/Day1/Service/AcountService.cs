using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace Service
{
    public class AcountService : IAcountService
    {

        public bool CheckLogin(ref AccountModel account, ref object people)
        {
            IAcountRepository acountRepository = new AcountRepository();
            return acountRepository.CheckLogin(ref account, ref people);
        }
        
    }
}
