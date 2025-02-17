namespace HomeWork_Collections.Task2.Exceptions;

public class WrongScoreValueException : Exception
{
    public WrongScoreValueException(Student student)
    {
        Console.WriteLine("Средний балл введен неверно");
    }
}