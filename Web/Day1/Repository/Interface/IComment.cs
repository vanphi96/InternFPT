using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IComment
    {
        int Create(comment comment);
        List<comment> GetCommentUser(int custommer_id);
        List<comment> GetCommentFilm(int film_id);
    }
}
