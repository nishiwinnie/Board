using System.Collections.Generic;
using System.Linq;
using Board.Data;
using Board.Entity;
using Board.Repository.Interface;

namespace Board.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(DataContext context){
            Context = context;
        }

        public DataContext Context { get; }
        public bool AddUser(User user)
        {
            Context.Users.Add(user);
            this.SaveChanges();
            return true;
        }

        public User FindByUserName(string UserName)
        {
            var detail = Context.Users.FirstOrDefault(x=> x.UserName == UserName);
            return detail;
        }

        public List<User> GetAllUsers()
        {
            return Context.Users.ToList();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public bool UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}