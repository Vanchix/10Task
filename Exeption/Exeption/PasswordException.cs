
namespace Exception
{
    public class PasswordException : IOException
    {
        public PasswordException() { }
        public PasswordException (string message) : base(message) { }
    }
}
