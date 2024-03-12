using UserManagement.Console.Models;

namespace UserManagement.Console.Services
{
    internal interface ILogInService
    {
        bool CheckUserLogIn(Credential credential);
        Credential AddCredential(Credential credential);

    }
}
