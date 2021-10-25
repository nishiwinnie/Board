using System.Collections.Generic;
using Board.Entity;

namespace Repository.Interface
{
    public interface ITaskTypeRepository
    {
        public List<TaskType> GetAllTaskType();
        public bool AddTaskType(TaskType taskType);

        public bool UpdateTaskType(TaskType taskType);

        public TaskType FindById(int id);
        public TaskType FindByName(string name);

        public void SaveChanges();
    }
}