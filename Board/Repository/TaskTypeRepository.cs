using System.Collections.Generic;
using System.Linq;
using Board.Data;
using Board.Entity;
using Repository.Interface;

namespace Repository
{
    public class TaskTypeRepository : ITaskTypeRepository
    {
        public TaskTypeRepository(DataContext context){
            Context = context;
        }

        public DataContext Context { get; }
        public bool AddTaskType(TaskType taskType)
        {
            Context.TaskType.Add(taskType);
            this.SaveChanges();
            return true;
        }

        public TaskType FindById(int id)
        {
            var detail = Context.TaskType.FirstOrDefault(x=> x.id == id);
            return detail;
        }

        public TaskType FindByName(string name)
        {
            var detail = Context.TaskType.FirstOrDefault(x=> x.Name == name);
            return detail;
        }

        public List<TaskType> GetAllTaskType()
        {
            return Context.TaskType.ToList();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public bool UpdateTaskType(TaskType taskType)
        {
            throw new System.NotImplementedException();
        }
    }
}