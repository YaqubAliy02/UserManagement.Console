
using UserManagement.Console.Models;

namespace UserManagement.Console.Brokers.Storages
{
    internal interface IStoragesBroker
    {
        /*Credential AddUser(Credential user);*/
        Credential[] GetAllCredentials();

    }
}
