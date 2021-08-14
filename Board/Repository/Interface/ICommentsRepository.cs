using System.Collections.Generic;
using Board.Entity;

namespace Repository.Interface
{
    public interface ICommentsRepository
    {
        public List<Comments> GetAllComments();
        public bool AddComments(Comments comments);

        public bool UpdateComments(Comments comments);

        public Comments FindById(int id);

        public void SaveChanges();
    }
}