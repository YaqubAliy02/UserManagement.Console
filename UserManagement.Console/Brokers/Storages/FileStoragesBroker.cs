using UserManagement.Console.Models;

namespace UserManagement.Console.Brokers.Storages
{
    internal class FileStoragesBroker : IStoragesBroker
    {
        private const string FILEPATH = "../../../Assets/User.txt";

        public FileStoragesBroker()
        {
            EnsureFileExists();
        }
        private static Credential[] credentials =
        {
            new Credential { UserName = "YaqubAliy", Password = "1234" },
            new Credential { UserName = "Temur", Password = "1234" }
        };


        public Credential AddCredential(Credential credential)
        {
            string userLine = $"{credential.UserName}-{credential.Password}";
            File.AppendAllText(FILEPATH, userLine);
            return credential;
        }

        public Credential[] GetAllCredentials() => credentials;

        private void  EnsureFileExists()
        {
            bool fileExists = File.Exists(FILEPATH);
            if(fileExists is false)
            {
                File.Create(FILEPATH).Close();
            }
        }
    }
}
