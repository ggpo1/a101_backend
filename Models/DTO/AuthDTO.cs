using a101_backend.Models.DataBase;
using a101_backend.Models.Enums;

namespace a101_backend.Models.DTO
{
    public class AuthDTO
    {
        public User User { get; set; }
        public UserAuthStatus Status { get; set; }
    }
}