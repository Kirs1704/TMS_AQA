namespace Excpetions;

public class CustomExceptionRunner
{
    public void Run()
    {
        try
        {
            // Генерим собственное исключение
            throw new CustomException("Произошла ошибка!");

            // Код, который после генерации исключения не выполнится
            Console.WriteLine("Этот код не будет выполнен из-за исключения выше");
        }
        catch (CustomException ex)
        {
            // Обрабатываем собственное исключение
            Console.WriteLine($"Поймано собственное исключение: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Этот блок нужен для обработки других исключений, если они возникнут
            Console.WriteLine($"Обнаружено исключение: {ex.Message}");
        }

    }
    
        public void ProcessInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new InvalidInputException(nameof(input),
                    "Поле не должно быть пустым или содержать только пробелы.");
            }
            // Дополнительная логика обработки ввода
        }
}