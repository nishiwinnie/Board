using System.Collections.Generic;
using Board.Entity;

namespace Repository.Interface
{
    public interface ITaskRepository
    {
        public List<Task> GetAllTask();
        public Task AddTask(Task task);

        public Task UpdateTask(Task task);

        public Task FindById(int id);

        public void SaveChanges();
    }
}