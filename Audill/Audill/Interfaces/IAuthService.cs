namespace Audill.Interfaces;

public interface IAuthService
{
    IEnumerable<AuthModel> GetUsers();
}