using HomeWork_Collections.Task2;

namespace HomeWork_Collections.Helper;

public class ShowHelper
{
    public ShowHelper(List<Student> student)
    {
        foreach (Student students in student)
        {
            Console.WriteLine(students);
        }
    }
}