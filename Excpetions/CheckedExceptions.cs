namespace Excpetions;


// В этом классе приводятся примеры контролируемых исключений
public class CheckedExceptions
{
    public void ReadFile(string filePath)                               // Метод, принимающий на вход путь к файлу
    {
        using (StreamReader reader = new StreamReader(filePath))        // спец. класс StreamReader, объект, которого читает файл по заданному пути
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }

    public void correctReadFile(string filePath)
    {
        try
        {
            ReadFile(filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
        }
    }

    public void TestException(int x, int y)
    {
        int result = x / y;
        Console.WriteLine(result);
    }
}