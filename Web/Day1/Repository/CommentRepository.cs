using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CommentRepository : IComment
    {
        private sakilaDB context = new sakilaDB();

        public int Create(comment comment)
        {
            context.comments.Add(comment);
            context.SaveChanges();
            return comment.id;

        }
        public List<comment> GetCommentUser(int custommer_id)
        {
            return context.comments.Where(x => x.customer_id == custommer_id).ToList();
        }
        public List<comment> GetCommentFilm(int film_id)
        {
            return context.comments.Where(x => x.film_id == film_id).ToList();
        }
    }
}
