using System.Collections.Generic;
using System.Linq;
using Board.Data;
using Board.Entity;
using Repository.Interface;

namespace Repository
{
    public class CommentsRepository : ICommentsRepository
    {
        public CommentsRepository(DataContext context){
            Context = context;
        }
        public DataContext Context { get; }
        public bool AddComments(Comments comments)
        {
            Context.Comments.Add(comments);
            this.SaveChanges();
            return true;
        }
        public Comments FindById(int id)
        {
            var detail = Context.Comments.FirstOrDefault(x=> x.id == id);
            return detail;
        }
        public List<Comments> GetAllComments()
        {
            return Context.Comments.ToList();
        }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public bool UpdateComments(Comments comments)
        {
            throw new System.NotImplementedException();
        }
    }
}