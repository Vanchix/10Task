
namespace Exception
{
    public class ExceptionHandling
    {
        public string login { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public static bool ExceptionHandlingMethod(string login, string password, string confirmPassword)
        {
            var passwordReturn = true;
            var loginReturn = true;
            var confirmPasswordReturn = true;
            try
            {
                if (login.Length > 20)
                {
                    throw new LoginException("WrongLoginException: Login exceeds 20 character limit");
                }
            }
            catch (LoginException ex)
            {
                Console.WriteLine(ex.Message);
                loginReturn = false;
            }
            try
            {
                if (login.Contains(' '))
                {
                    throw new LoginException("WrongLoginException: Login contains spaces");
                }
            }
            catch (LoginException ex)
            {
                Console.WriteLine(ex.Message);
                loginReturn = false;
            }


            try
            {
                if (password.Length > 20)
                {
                    throw new PasswordException("WrongPasswordException: Password exceeds 20 character limit");
                }
            }
            catch (PasswordException ex)
            {
                Console.WriteLine(ex.Message);
                passwordReturn = false;
            }
            try
            {
                if (password.Contains(' '))
                {
                    throw new PasswordException("WrongPasswordException: Password contains spaces");
                }
            }
            catch (PasswordException ex)
            {
                Console.WriteLine(ex.Message);
                passwordReturn = false;
            }
            try
            {
                var passwordDigitSymbols = 0;
                foreach (char symbol in password)
                {
                    if (char.IsDigit(symbol))
                    {
                        passwordDigitSymbols++;              // проверка на наличие хотя бы одной цифры
                    }
                }
                if (passwordDigitSymbols == 0)
                {
                    throw new PasswordException("WrongPasswordException: Password do not contains numbers");
                }
            }
            catch (PasswordException ex)
            {
                Console.WriteLine(ex.Message);
                passwordReturn = false;
            }
            try
            {
                if(confirmPassword != password)
                {
                    throw new PasswordException("WrongPasswordException: Passwords missmatch");
                }
            }
            catch (PasswordException ex)
            {
                Console.WriteLine(ex.Message);
                confirmPasswordReturn = false;
            }
            if (loginReturn & passwordReturn & confirmPasswordReturn)
            {
                Console.WriteLine("all true");
                return true;
            }
            else
            {
                Console.WriteLine("Error:");
                return false;
            }
        }
    }
}
