
using UserManagement.Console.Models;

namespace UserManagement.Console.Brokers.Storages
{
    internal interface IStoragesBroker
    {
        Credential AddCredential(Credential credential);
        Credential[] GetAllCredentials();

    }
}
