using Audill.Services.Interfaces;

namespace Audill.Services;

public class AuthService : IAuthService
{
    public IEnumerable<AuthModel> GetUsers()
    {
        return new List<AuthModel>
        {
            new AuthModel() { Id = 0, UserName = "Ray" },
            new AuthModel() { Id = 1, UserName = "Graves" },
        };
    }
}