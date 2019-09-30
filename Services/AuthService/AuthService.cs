using System.Threading.Tasks;
using a101_backend.Models;
using a101_backend.Models.Enums;
using a101_backend.Models.DataBase;
using System.Linq;

using a101_backend.Models.DTO;

namespace a101_backend.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public async Task<object> GetAuth(AuthUserDTO user)
        {
            User usr = MyDb.db.Users.FirstOrDefault(elem => elem.UserName == user.Login);
            if (user.Password != usr.PasswordHash)
                return await Task.Run(() => new { User = new { UserID = usr.UserID, UserName = usr.UserName, UserEmail = usr.UserEmail }, Status = UserAuthStatus.FAILED });

            return await Task.Run(() => new AuthDTO() { User = usr, Status = UserAuthStatus.SUCCESSED });
        } 
    }
}