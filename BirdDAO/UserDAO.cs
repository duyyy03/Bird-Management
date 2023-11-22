using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace BirdDAO
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        public User GetUserByUsername(string user)
        {
            try
            {
                var dbContent = new BirdContext();
                return dbContent.Users.SingleOrDefault(m => m.Username.Equals(user));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public User Authenticate(string usernameOrEmail, string password)
        //{
        //    User user = Get(usernameOrEmail);
        //    if (user == null || user.Password.Equals(password) == false)
        //        return null;

        //    if (user.Enabled == false)
        //        throw new Exception("YOUR ACCOUNT WAS BANNED");

        //    return user;
        //}

        public void Update(User entity)
        {
            try
            {
                using (var context = new BirdContext())
                {


                    if (Instance.Exist(entity.Username) == false)
                    {
                        throw new Exception("The entity does not exist: " + entity.Username);
                    }

                    context.Entry<User>(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " : " + entity.Username);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var dbContent = new BirdContext();
                if(user != null)
                {
                    dbContent.Users.Update(user);
                    dbContent.SaveChanges();
                }               
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(User user)
        {
            try
            {
                //using (var context = new BirdContext())
                //{
                //    if (Instance.Exist(entity.Username) || Instance.Exist(entity.Email))
                //    {
                //        throw new Exception("Duplicated entity (username or email).");
                //    }

                //    context.Users.Add(entity);
                //    context.SaveChanges();
                //}

                var dbContent = new BirdContext();
                dbContent.Users.Add(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Exist(string usernameOrEmailOrPhone)
        {
            User entity = null;
            try
            {
                using (var context = new BirdContext())
                {
                    entity = context.Users.SingleOrDefault(item =>
                                                                item.Username.ToLower().Equals(usernameOrEmailOrPhone.ToLower())
                                                            || item.Email.ToLower().Equals(usernameOrEmailOrPhone.ToLower())
                                                            || item.Phone.Equals(usernameOrEmailOrPhone));

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity != null;
        }
        public User Get(string usernameOrEmailOrPhone)
        {
            User entity = null;
            try
            {
                using (var context = new BirdContext())
                {
                    entity = context.Users.SingleOrDefault(item =>
                                                                item.Username.ToLower().Equals(usernameOrEmailOrPhone.ToLower())
                                                            || item.Email.ToLower().Equals(usernameOrEmailOrPhone.ToLower())
                                                            || item.Phone.Equals(usernameOrEmailOrPhone));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
            //sdfsdfsdfsdf
        }
        public List<User> GetAllUsers()
        {
            try
            {
                var dbContext = new BirdContext();
                return dbContext.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
