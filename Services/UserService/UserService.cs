using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using a101_backend.Models;
using a101_backend.Models.DataBase;

namespace a101_backend.Services.UserService
{
    public class UserService : IUserService
    {
        public async Task<object> AddNewUser(User user)
        {
            var added = MyDb.db.User.Add(user);
            MyDb.db.SaveChanges();
            return await Task.Run(() => (object) new { added.Entity.UserID });
        }

        public async Task<User> DeleteUser(int userID)
        {
            var el = MyDb.db.User.FirstOrDefault(elem => elem.UserID == userID);
            MyDb.db.User.Remove(el);
            MyDb.db.SaveChanges();
            return await Task.Run(() => el);
        }

        public async Task<List<User>> GetUsers()
        {
            return await Task.Run(() => MyDb.db.User.ToList());
        }
    }
}
