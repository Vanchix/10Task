
namespace Exception
{
    public class LoginException : IOException
    {
        public LoginException() { }
        public LoginException(string message) : base(message) { }
    }
}
