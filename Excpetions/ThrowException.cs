namespace Excpetions;

public class ThrowException
{
    public void CheckUserName()
    {
        try
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            if (name == null || name.Length < 2)
            {
                throw new Exception("Имя не может быть короче двух символов!");       // вот так создается новый (кастомный) экземпляр Exception
            }
            else
            {
                Console.WriteLine($"Ваше имя: {name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}