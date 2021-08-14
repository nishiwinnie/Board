using System.Collections.Generic;
using System.Linq;
using Board.Data;
using Board.Entity;
using Repository.Interface;

namespace Repository
{
    public class SprintRepository : ISprintRepository
    {
        public SprintRepository(DataContext context){
            Context = context;
        }

        public DataContext Context { get; }
        public bool AddSprint(Sprint sprint)
        {
            Context.Sprint.Add(sprint);
            this.SaveChanges();
            return true;
        }

        public Sprint FindById(int id)
        {
            var detail = Context.Sprint.FirstOrDefault(x=> x.id == id);
            return detail;
        }

        public List<Sprint> GetAllSprint()
        {
            return Context.Sprint.ToList();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public bool UpdateSprint(Sprint sprint)
        {
            throw new System.NotImplementedException();
        }
    }
}