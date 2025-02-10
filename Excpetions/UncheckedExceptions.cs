namespace Excpetions;

public class UncheckedExceptions
{
    // Пример неконтролируемого исключения
    public void DivideNumbers(int a, int b)                              // Метод, кот. производит деление двух чисел
    {
        int result = a / b;  // Возможно возникновение DivideByZeroException ("Делить на ноль нельзя")
    }
}