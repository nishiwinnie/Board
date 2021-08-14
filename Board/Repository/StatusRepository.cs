using System.Collections.Generic;
using System.Linq;
using Board.Data;
using Board.Entity;
using Repository.Interface;

namespace Repository
{
    public class StatusRepository : IStatusRepository
    {
        public StatusRepository(DataContext context){
            Context = context;
        }

        public DataContext Context { get; }
        public bool AddStatus(Status status)
        {
            Context.Status.Add(status);
            this.SaveChanges();
            return true;
        }

        public Status FindByName(string name)
        {
            var detail = Context.Status.FirstOrDefault(x=> x.Name == name);
            return detail;
        }
        public Status FindById(int id)
        {
            var detail = Context.Status.FirstOrDefault(x=> x.id == id);
            return detail;
        }

        public List<Status> GetAllStatus()
        {
            return Context.Status.ToList();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public bool UpdateStatus(Status status)
        {
            throw new System.NotImplementedException();
        }
        
    }
}