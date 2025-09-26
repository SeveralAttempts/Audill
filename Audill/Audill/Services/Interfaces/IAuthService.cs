namespace Audill.Services.Interfaces;

public interface IAuthService
{
    IEnumerable<AuthModel> GetUsers();
}