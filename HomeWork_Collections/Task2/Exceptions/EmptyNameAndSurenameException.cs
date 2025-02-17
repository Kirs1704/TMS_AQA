namespace HomeWork_Collections.Task2.Exceptions;

public class EmptyNameAndSurenameException : Exception
{
    public EmptyNameAndSurenameException(Student student)
    {
        if (string.IsNullOrWhiteSpace(student.Name) ||
            string.IsNullOrWhiteSpace(student.Surname) || string.IsNullOrEmpty(student.Name) ||
            string.IsNullOrEmpty(student.Surname))
        {
            Console.WriteLine("Имя и фамилия не могут быть пустыми или состоять из пробелов. Попробуйте еще раз");
        }
    }    
}