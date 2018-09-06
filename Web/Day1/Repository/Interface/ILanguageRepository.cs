using System.Collections.Generic;
using Model;

namespace Repository
{
    public interface ILanguageRepository
    {
        int Create(language language);
        bool Delete(byte id);
        List<language> GetAll();
        language GetByID(byte id);
        bool Update(language language);
    }
}