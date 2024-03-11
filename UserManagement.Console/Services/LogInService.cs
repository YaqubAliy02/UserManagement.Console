using UserManagement.Console.Brokers.Storages;
using UserManagement.Console.Models;
namespace UserManagement.Console.Services
{
    internal class LogInService
    {
        private readonly IStoragesBroker storagesBroker;
        public LogInService()
        {
            this.storagesBroker = new FileStoragesBroker();
        }
        public bool CheckUserLogIn(Credential credential)
        {
            foreach(Credential credentialItem in storagesBroker.GetAllCredentials())
            {
                if(credentialItem.UserName == credential.UserName && credentialItem.Password == credential.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
