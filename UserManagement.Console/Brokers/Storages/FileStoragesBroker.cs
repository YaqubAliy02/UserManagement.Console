using UserManagement.Console.Models;

namespace UserManagement.Console.Brokers.Storages
{
    internal class FileStoragesBroker : IStoragesBroker
    {
        private static Credential[] credentials =
        {
            new Credential { UserName = "YaqubAliy", Password = 12234 },
            new Credential { UserName = "Temur", Password = 3543 }
        };
        public Credential[] GetAllCredentials() => credentials;
    }
}
