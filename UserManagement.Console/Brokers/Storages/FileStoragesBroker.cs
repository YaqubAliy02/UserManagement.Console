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
        public Credential AddCredential(Credential credential)
        {
            string userLine = $"{credential.UserName}-{credential.Password}\n";
            File.AppendAllText(FILEPATH, userLine);
            return credential;
        }
        public Credential[] GetAllCredentials()
        {
            string[] credentialLines = File.ReadAllLines(FILEPATH);
            int credentialLength = credentialLines.Length;
            Credential[] credentials = new Credential[credentialLength];
            
            for(int iteration = 0; iteration < credentialLength; iteration++)
            {
                string credentialLine = credentialLines[iteration];
                string[] credtentialProperties = credentialLine.Split("-");
                Credential credential = new Credential
                {
                    UserName = credtentialProperties[0],
                    Password = credtentialProperties[1]
                };
                credentials[iteration] = credential;
            }
            return credentials;
        }
        public bool CheckUserLogIn(Credential credential)
        {
            foreach (Credential credentialItem in GetAllCredentials())
            {
                if (credentialItem.UserName == credential.UserName && credentialItem.Password == credential.Password)
                {
                  return true;
                }
            }
            return false;
        }
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
