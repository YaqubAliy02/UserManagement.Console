using System;
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


            do
            {
                Print();
                System.Console.Write("Enter you choice:");
                userChoice = System.Console.ReadLine();
                switch(userChoice)
                {
                    case "1":
                        {
                            System.Console.Clear();
                            Credential credential = new Credential();

                            System.Console.Write("Enter your userName:");
                            string userName = System.Console.ReadLine();
                            credential.UserName = userName;
                            System.Console.Write("Enter your password:");
                            string userPassword = System.Console.ReadLine();
                            credential.Password = userPassword;
                            logInService.AddCredential(credential);

                        }
                    break;
                }

            } while (userChoice is not "0");
        }
        
        static void Print()
        {
           System.Console.WriteLine("1. SignUp");
           System.Console.WriteLine("2. LogIn");
        }
    }
}

