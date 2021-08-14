using System.Collections.Generic;
using Board.Entity;

namespace Repository.Interface
{
    public interface ISprintRepository
    {
        public List<Sprint> GetAllSprint();
        public bool AddSprint(Sprint sprint);

        public bool UpdateSprint(Sprint sprint);

        public Sprint FindById(int id);

        public void SaveChanges();
    }
}