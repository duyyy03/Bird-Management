using BusinessObjects.Models;

namespace BirdRepository
{
    public interface IUserRepository
    {
        User getUserByEmail(string email);
        List<User> getAllUsers();
        bool UserExit(string usernameOrEmailOrPhone);
        void Create(User user);
        void UpdateUser(User user);
    }
}
