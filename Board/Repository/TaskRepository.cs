using System.Collections.Generic;
using System.Linq;
using Board.Data;
using Board.Entity;
using Repository.Interface;

namespace Repository
{
    public class TaskRepository : ITaskRepository
    {
        public TaskRepository(DataContext context){
            Context = context;
        }

        public DataContext Context { get; }
        public bool AddTask(Task task)
        {
            Context.Task.Add(task);
            this.SaveChanges();
            return true;
        }

        public Task FindById(int id)
        {
            var detail = Context.Task.FirstOrDefault(x=> x.id == id);
            return detail;
        }

        public List<Task> GetAllTask()
        {
            return Context.Task.ToList();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public bool UpdateTask(Task task)
        {
            throw new System.NotImplementedException();
        }
    }
}