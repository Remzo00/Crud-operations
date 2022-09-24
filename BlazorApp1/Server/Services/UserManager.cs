using BlazorApp1.Server.Interfaces;
using BlazorApp1.Server.Models;
using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Services
{
    public class UserManager : IUser
    {
        private readonly DatabaseContext _dbContext;
        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<User> GetUserDetails()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void AddUser(User user)
        {
            try
            {
                _dbContext.Users?.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                User? user = _dbContext.Users?.Find(id);
                if (user != null)
                {
                    _dbContext.Users?.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public User GetUserData(int id)
        {
            try
            {
                User? user = _dbContext.Users?.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
               
        public void UpdateUserDetails(User user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
