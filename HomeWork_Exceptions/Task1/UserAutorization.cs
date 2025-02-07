namespace HomeWork_Exceptions.Task1;

public class UserAutorization
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }


    public void UserEnter(string login, string password, string confirmPassword)
    {

        WrongLoginException wrongLoginException= new WrongLoginException(login);
        WrongPasswordException wrongPasswordException = new WrongPasswordException(password);
        if (confirmPassword != password)
        {
            throw new Exception("Введенные пароли не совпадают");
        }
        else
        {
            Console.WriteLine("Поздравляем! Вы успешно зарегистрированы в системе!");
        }


    }
}