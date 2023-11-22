using BusinessObjects.Models;

namespace BirdService
{
    public interface IUserService
    {
        User GetUserByUsername(string user);
        List<User> GetAllUsers();
        bool UserExit(string usernameOrEmailOrPhone);
        void Create(User user);
        void UpdateUser(User user);
    }
}
