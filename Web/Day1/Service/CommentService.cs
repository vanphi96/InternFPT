using Model;
using Repository;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CommentService : ICommentService
    {
        private IComment cmt = new CommentRepository();
        public int Create(comment comment)
        {
            return cmt.Create(comment);
        }

        public List<comment> GetCommentFilm(int film_id)
        {
            return cmt.GetCommentFilm(film_id);
        }

        public List<comment> GetCommentUser(int custommer_id)
        {
            return cmt.GetCommentUser(custommer_id);
        }
    }
}
