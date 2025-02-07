namespace Excpetions;

public class ExceptionUsage
{
    private CheckedExceptions checkedExceptions = new CheckedExceptions();


    public void Template()
    {
        try
        {
            checkedExceptions.ReadFile("file.txt");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex);
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"InnerException: {ex.InnerException}"); // выведет информацию об исключении, которое является причиной текущего исключения
            Console.WriteLine($"Message: {ex.Message}"); // выведет сообщение об исключении, текст ошибки
            Console.WriteLine($"Source: {ex.Source}"); // выведет имя объекта или сборки, которое вызвало исключение
            Console.WriteLine(
                $"StackTrace: {ex.StackTrace}"); // выведет строковое представление стека вызовов, которые привели к исключению
            Console.WriteLine($"TargetSite: {ex.TargetSite}"); // выведет метод, в котором вызвано исключениеs
        }
        finally
        {
            Console.WriteLine("Закончили обработку исключений");
        }
    }
    
    public void FilterCatch(int x, int y)
    {
        try
        {
            int result1 = x / y;
            int result2 = y / x;
        }
        catch (DivideByZeroException) when(y == 0)   // это блок с доп. условием. Читается, как "Если Exception типа DivideByZeroException и при этом y=0, тогда..."
        {
            Console.WriteLine("'y' не может быть 0");
        }
    }
}