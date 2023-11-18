using ToDoList.DatabaseContext;
using ToDoList.Models;

namespace ToDoList.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public List<UserModel> GetAll()
        {
            return _context.Users.ToList();
        }

        public UserModel GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public UserModel Create(UserModel model)
        {
            UserModel user = model;

            if (user == null)
            {
                return null;
            }

            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public UserModel Update(UserModel model)
        {
            UserModel user = GetById(model.Id);
            if (user == null)
            {
                return null;
            }

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;

            user.UpdatedAt = DateTime.Now;

            _context.Users.Update(user);
            _context.SaveChanges();

            return user;
        }

        public bool Delete(int id)
        {
            UserModel user = GetById(id);

            if (user == null)
            {
                return false;
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return true;

        }
    }
}
