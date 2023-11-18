using ToDoList.Models;

namespace ToDoList.Repositories.TaskRepository
{
    public interface ITaskRepository
    {
        public List<TaskModel> GetAll();
        public TaskModel GetById(int id);
        public TaskModel Create(TaskModel model);
        public TaskModel Update(TaskModel model);
        public bool Delete(int id);
    }
}
