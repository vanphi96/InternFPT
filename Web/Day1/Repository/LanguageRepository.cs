using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        private sakilaEntities contex = new sakilaEntities();
        public int Create(language language)
        {
            contex.languages.Add(language);
            contex.SaveChanges();
            return language.language_id;
        }
        public language GetByID(byte id)
        {
            return contex.languages.FirstOrDefault(x => x.language_id.Equals(id));
        }
        public bool Delete(byte id)
        {
            var delete = GetByID(id);
            if (delete != null)
            {
                contex.languages.Remove(delete);
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public bool Update(language language)
        {
            var current = GetByID(language.language_id);
            if (current != null)
            {
                current.films = language.films;
                current.films1 = language.films1;
                current.last_update = language.last_update;
                current.name = language.name;
                
                return contex.SaveChanges() > 0;
            }
            return false;
        }
        public List<language> GetAll()
        {
            return contex.languages.ToList();
        }
    }
}
