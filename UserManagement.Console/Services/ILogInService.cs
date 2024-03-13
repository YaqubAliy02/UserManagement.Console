using UserManagement.Console.Models;
namespace UserManagement.Console.Services
{
    internal interface ILogInService
    {
        bool CheckCredentialLogIn(Credential credential);
        Credential AddCredential(Credential credential);
    }
}
