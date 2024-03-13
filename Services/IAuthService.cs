using OznurYilmazBackEnd.Models;

namespace OznurYilmazBackEnd.Services
{
    public interface IAuthService
    {
        Task<AuthModel> Registerasync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);

        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthModel> RefreshTokenAsync(string token);

        Task<bool> RevokeTokenAsync(string token);

    }
}
