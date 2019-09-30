using System.Threading.Tasks;

using a101_backend.Models.DTO;

namespace a101_backend.Services.AuthService
{
    public interface IAuthService
    {
        Task<object> GetAuth(AuthUserDTO user);
    }
}