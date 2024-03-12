using UserManagement.Console.Models;
namespace UserManagement.Console.Services
{
    internal interface ILogInService
    {
        void CheckCredentialLogIn(Credential credential);
        Credential AddCredential(Credential credential);
    }
}
