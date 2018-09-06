using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ILanguageService
    {
        int Create(language language);
        bool Delete(byte id);
        List<language> GetAll();
        language GetByID(byte id);
        bool Update(language language);
    }
}
