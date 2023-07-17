using Exception;

var user = new ExceptionHandling();
do
{
    Console.Write("Input login: ");
    user.login = Console.ReadLine();
    Console.Write("Input password: ");
    user.password = Console.ReadLine();
    Console.Write("Confirm password: ");
    user.confirmPassword = Console.ReadLine();
} while (ExceptionHandling.ExceptionHandlingMethod(user.login, user.password, user.confirmPassword) != true);