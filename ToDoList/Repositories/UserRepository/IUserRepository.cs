using ToDoList.Models;

namespace ToDoList.Repositories.UserRepository
{
    public interface IUserRepository
    {

        public List<UserModel> GetAll();
        public UserModel GetById(int id);
        public UserModel Create(UserModel model);
        public UserModel Update(UserModel model);
        public bool Delete(int id);
    }
}
