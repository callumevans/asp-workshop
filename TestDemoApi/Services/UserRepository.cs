using System.Collections.Generic;
using System.Linq;
using TestDemoApi.Models;

namespace TestDemoApi.Services
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();
        
        public void CreateUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetUsers()
        {
            return _users.ToList();
        }

        public User GetUser(int id)
        {
            var user = _users.SingleOrDefault(user => user.Id == id);
            return user;
        }
    }
}