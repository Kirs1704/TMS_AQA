namespace HomeWork_Collections.Task2.Exceptions;

public class WrongAgeException : Exception
{
    public WrongAgeException(Student student)
    {
        if (student.Age < 17 || student.Age > 60)
        {
            Console.WriteLine("Некорректный возраст студента");
        }
    }
}