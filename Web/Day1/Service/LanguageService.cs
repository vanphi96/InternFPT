using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class LanguageService : ILanguageService
    {
        private ILanguageRepository languageRepository = new LanguageRepository();
        public int Create(language language)
        {
            return languageRepository.Create(language);
        }

        public bool Delete(byte id)
        {
            return languageRepository.Delete(id);
        }

        public List<language> GetAll()
        {
            return languageRepository.GetAll();
        }

        public language GetByID(byte id)
        {
            return languageRepository.GetByID(id);
        }

        public bool Update(language language)
        {
            return languageRepository.Update(language);
        }
    }
}
