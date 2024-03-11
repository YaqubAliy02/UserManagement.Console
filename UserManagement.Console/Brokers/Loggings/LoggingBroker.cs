namespace UserManagement.Console.Brokers.Loggings
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void LogError(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }
        public void LogError(Exception exception)
        {
            System.Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(exception);
            System.Console.ResetColor();
        }
        public void LogInformation(string message)
        {
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }
        public void LogSuccessUser(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);
            System.Console.ResetColor();
        }
    }
}
