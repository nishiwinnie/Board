using System.Collections.Generic;
using Board.Entity;

namespace Board.Repository.Interface
{
    public interface IUserRepository 
    {
        public List<User> GetAllUsers(); //comment
        public bool AddUser(User user);

        public bool UpdateUser(User user);

        public User FindByUserName(string UserName);

        public void SaveChanges();
    }
}