namespace CateringBusinessLogic
{
    public class AuthenticationService
    {
        private readonly string adminUsername = "zeljhay";
        private readonly string adminPassword = "123";

        public bool Login(string username, string password)
        {
            if (username == adminUsername && password == adminPassword)
            {
                return true;
            }

            return false;
        }
    }
}