using UserManagement.Console.Models;
using UserManagement.Console.Services;
namespace UserManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            LogInService logInService = new LogInService();
            string userChoice;
            int choice = 0;
                do
                {
                    Print();
                    System.Console.Write("Enter your choice: ");
                    userChoice = System.Console.ReadLine();
                    try
                    {
                        choice = Convert.ToInt32(userChoice);
                        switch (choice)
                        {
                            case 1:
                                {
                                    Credential credential = new Credential();
                                    System.Console.Write("Enter your username: ");
                                    string newUserName = System.Console.ReadLine();
                                    credential.UserName = newUserName;
                                    System.Console.Write("Enter your password: ");
                                    string newUserPassword = System.Console.ReadLine();
                                    credential.Password = newUserPassword;
                                    logInService.AddCredential(credential);
                                }
                                break;

                            case 2:
                                {
                                    Credential credential = new Credential();
                                    System.Console.Write("Username: ");
                                    string userName = System.Console.ReadLine();
                                    credential.UserName = userName;
                                    System.Console.Write("Password: ");
                                    string password = System.Console.ReadLine();
                                    credential.Password = password;
                                    logInService.CheckCredentialLogIn(credential);
                                }
                                break;

                            case 0:
                                {
                                    System.Console.WriteLine("Exiting program...");
                                    break;
                                }
                            default:
                                {
                                    throw new Exception("Invalid choice. Please enter a valid option.");
                                }
                        }
                    }
                    catch (FormatException)
                    {
                        System.Console.WriteLine("Invalid input. Please enter a valid integer choice.");
                        choice = -1;
                    }
                    catch (Exception exception)
                    {
                        System.Console.WriteLine(exception.Message);
                    }

                System.Console.Write("Do you want to continue yes(y) or no(n): ");
                string continueChoice = System.Console.ReadLine();

                if (continueChoice.ToLower() != "y")
                {
                   System.Console.WriteLine("Thank you for using our console app");
                    break;
                }

            } while (choice != 0);
        }
        static void Print()
        {
            System.Console.WriteLine("1. Sign Up");
            System.Console.WriteLine("2. Log In");
            System.Console.WriteLine("0. Exit");
        }
      
    }
}