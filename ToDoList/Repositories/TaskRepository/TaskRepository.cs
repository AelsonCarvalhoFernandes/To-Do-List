using ToDoList.DatabaseContext;
using ToDoList.Models;

namespace ToDoList.Repositories.TaskRepository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataContext _context;

        public TaskRepository(DataContext context)
        {
            _context = context;
        }

        public List<TaskModel> GetAll()
        {
            return _context.Tasks.ToList();
        }

        public TaskModel GetById(int id)
        {
            return _context.Tasks.SingleOrDefault(x => x.Id == id);
        }

        public TaskModel Create(TaskModel model)
        {
            TaskModel task = model;

            if(task == null)
            {
                return null;
            }

            task.CreatedAt = DateTime.Now;
            task.UpdatedAt = DateTime.Now;

            _context.Tasks.Add(task);
            _context.SaveChanges();

            return task;
        }

        public TaskModel Update(TaskModel model)
        {
            TaskModel task = GetById(model.Id);

            if (task == null)
            {
                return null;
            }

            task.Name = model.Name;
            task.Description = model.Description;
            task.Status = model.Status;
            task.Note = model.Note;

            task.CreatedAt = DateTime.Now;
            task.UpdatedAt = DateTime.Now;

            _context.Tasks.Update(task);
            _context.SaveChanges();

            return task;
        }

        public bool Delete(int id)
        {
            TaskModel task = GetById(id);

            if (task == null)
            {
                return false;
            }

            _context.Tasks.Remove(task);
            _context.SaveChanges();

            return true;
        }

    }
}
