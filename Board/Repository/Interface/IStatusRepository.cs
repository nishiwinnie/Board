using System.Collections.Generic;
using Board.Entity;

namespace Repository.Interface
{
    public interface IStatusRepository
    {
        public List<Status> GetAllStatus();
        public bool AddStatus(Status status);

        public bool UpdateStatus(Status status);

        public Status FindByName(string name);
        public Status FindById(int id);

        public void SaveChanges();
    }
}