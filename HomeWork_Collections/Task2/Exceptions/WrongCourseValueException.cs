namespace HomeWork_Collections.Task2.Exceptions;

public class WrongCourseValueException : Exception
{
    public WrongCourseValueException(Student student)
    {
        Console.WriteLine("Недопустимое значение для выбора курса");
    }
}