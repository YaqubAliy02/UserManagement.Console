using UserManagement.Console.Brokers.Loggings;
using UserManagement.Console.Brokers.Storages;
using UserManagement.Console.Models;
namespace UserManagement.Console.Services
{
    internal class LogInService : ILogInService
    {
        private readonly IStoragesBroker storagesBroker;
        private readonly ILoggingBroker loggingBroker;
        public LogInService()
        {
            this.storagesBroker = new FileStoragesBroker();
            this.loggingBroker = new LoggingBroker();
        }
        public Credential AddCredential(Credential credential)
        {
            return credential is null
                 ? AddCredentialAndLogInvalidUser()
                 : ValidateAndAddCredential(credential);
        }
        private Credential AddCredentialAndLogInvalidUser()
        {
            this.loggingBroker.LogError("Credential is invalid");
            return new Credential();
        }
        private Credential ValidateAndAddCredential(Credential credential)
        {
            if (String.IsNullOrWhiteSpace(credential.UserName) || String.IsNullOrWhiteSpace(credential.Password))
            {
                this.loggingBroker.LogError("User details missing.");
                return new Credential();
            }
            else
            {
                this.loggingBroker.LogSuccessUser("Signed Up Successfully");
                return this.storagesBroker.AddCredential(credential);          
            }
        }
        public void CheckCredentialLogIn(Credential credential)
        {
            if(storagesBroker.CheckUserLogIn(credential))
            {
                this.loggingBroker.LogSuccessUser("Welcome to our website");
            }
            else
            {
                this.loggingBroker.LogInformation("Not found this user, Please Sign Up");
            }
        }

    }
}
