using APIGoogleAuthorization.Models;

namespace APIGoogleAuthorization.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRolesAsync(AddRoleModel model);
    }
}
